


using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace PracticaMiguelGaibor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals("") || tbPass.Text.Equals(""))
            {
                
                MessageBox.Show
                    ("Ingrese credenciales", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(conection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select a.nombre , a.apellido ,  a.idrol, b.ABREVIATURA , b.NOMBRE from persona a join estado b on a.US_ESTADO = b.IDESTADO where usuario = @usuario and password = @pass", conn);
                cmd.Parameters.AddWithValue("@usuario", tbUser.Text);
                cmd.Parameters.AddWithValue("@pass", tbPass.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.GetString(0).IsNullOrEmpty())
                {
                    MessageBox.Show("Acceso correcto " + reader.GetString(0) + " " + reader.GetString(1));
                    switch (reader.GetInt32(2))
                    {
                        case 1:
                            //Buscador
                            this.Hide();
                            PrincipalBuscador pb = new PrincipalBuscador();
                            pb.lblLogin.Text = reader.GetString(0) + " " + reader.GetString(1);
                            pb.Show();
                            break;

                        case 2:
                            //ciudadano
                            this.Hide();
                            PrincipalCiudadano pc = new PrincipalCiudadano();
                            pc.lblLoginC.Text = reader.GetString(0) + " " + reader.GetString(1);
                            pc.lblEstadoUS.Text = reader.GetString(4);
                            pc.lblAbre.Text = reader.GetString(3);
                            pc.Show();
                            break;
                        case 3:
                            this.Hide();    
                            PrincipalAdmin pa = new PrincipalAdmin();
                            pa.lblLoginA.Text = reader.GetString(0) + " " + reader.GetString(1);
                            pa.Show();  
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    ("Credenciales incorrectas, por favor valide su usuario o contraseña e intente nuevamente", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}