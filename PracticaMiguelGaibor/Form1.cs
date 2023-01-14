


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
                MessageBox.Show("Ingrese credenciales");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(conection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select nombre , apellido from persona where usuario = @usuario and password = @pass", conn);
                cmd.Parameters.AddWithValue("@usuario", tbUser.Text);
                cmd.Parameters.AddWithValue("@pass", tbPass.Text);
                SqlDataReader reader = cmd.ExecuteReader(); 
                reader.Read();  
                if (!reader.GetString(0).IsNullOrEmpty())
                {
                    MessageBox.Show("Simón " + reader.GetString(0)+ " " + reader.GetString(1));
                }
                else
                {
                    MessageBox.Show("NEL");
                }


            }
            catch (Exception ex)
            { MessageBox.Show("OOPS: " + ex.ToString()); }
        }
    }
}