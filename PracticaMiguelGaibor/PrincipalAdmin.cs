using Microsoft.Data.SqlClient;
using System.Data;

namespace PracticaMiguelGaibor
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnAgregaUsuario_Click(object sender, EventArgs e)
        {

            if (ValidaDatos())
            {
                GuardaUsuario(); 
            }

        }


        private bool ValidaDatos()
        {
            bool res = true;
            string msg = "";
            if (tbANombre.Text.Length <= 0)
            {
                msg += "Ingrese Nombre \n";
                res = false;
            }
            if (tbAApellido.Text.Length <= 0)
            {
                msg += "Ingrese Apellido \n";
                res = false;
            }
            if (cbAEstado.Text.Equals("SELECCIONE"))
            {
                msg += "Seleccione estado \n";
                res = false;
            }
            if (tbAUsuario.Text.Length <= 0)
            {
                msg += "Ingrese Usuario \n";
                res = false;
            }
            if (tbAPass1.Text.Length <= 0)
            {
                msg += "Ingrese Password\n";
                res = false;
            }
            if (tbAPass2.Text.Length <= 0)
            {
                msg += "Ingrese confirmación de Password \n";
                res = false;
            }
            if (cbARol.Text.Equals("SELECCIONE"))
            {
                msg += "Seleccione Rol \n";
                res = false;
            }
            if (!tbAPass1.Text.Equals(tbAPass2.Text))
            {
                msg += "Password no coincide \n";
                res = false;
            }

            if (!res)
            {
                MessageBox.Show
                   (msg, "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return res;
        }

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            TraeHistorial();
            TraeRoles();
            TraeEstados();
            this.FormClosed += new FormClosedEventHandler(cierraVentana);
        }

        private void cierraVentana(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void TraeRoles()
        {
            string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(conection))
            {
                conn.Open();
                String queryInsert = "select descripcion from rol";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbARol.Items.Add(reader["descripcion"].ToString());
                }
            }
        }
        private void TraeEstados()
        {
            string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(conection))
            {
                conn.Open();
                String queryInsert = "SELECT concat(nombre , ' / ' , abreviatura , ' / ', idestado)  as nombre FROM estado";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbAEstado.Items.Add(reader["nombre"].ToString());
                }
            }
        }

        private void TraeHistorial()
        {
            
            try
            {
                string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(conection);
                conn.Open();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("select usuario , rol , fecha_consulta , parametros_consulta from historial", conn);
                da.Fill(dt);
                dgvHistorial.DataSource = dt;
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            catch (Exception ex) { }
        }
        private void GuardaUsuario()
        {
            try
            {
                string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(conection))
                {
                    int rol = 1;
                    
                    switch (cbARol.Text)
                    {
                        case "BUSCADOR":
                            rol = 1;

                            break;
                        case "CIUDADANO":
                            rol = 2;
                            break;
                        case "ADMIN":
                            rol = 3;
                            break;
                    }
                    int abre = Int16.Parse(cbAEstado.Text.Split('/')[2]);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into persona (NOMBRE , APELLIDO, CORREO , US_ESTADO , USUARIO , PASSWORD , IDROL )\r\nvalues (@NOMBRE , @APELLIDO, @CORREO , @US_ESTADO , @USUARIO , @PASSWORD , @IDROL )", conn);
                    cmd.Parameters.AddWithValue("@NOMBRE", tbANombre.Text);
                    cmd.Parameters.AddWithValue("@APELLIDO", tbAApellido.Text);
                    cmd.Parameters.AddWithValue("@CORREO", tbACorreo.Text);
                    cmd.Parameters.AddWithValue("@US_ESTADO", 1);
                    cmd.Parameters.AddWithValue("@USUARIO", tbAUsuario.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", tbAPass1.Text);
                    cmd.Parameters.AddWithValue("@IDROL", rol);
                    int validador = cmd.ExecuteNonQuery();
                    if (validador == 1)
                    {

                        Log logger = Log.getInstance();
                        logger.logea(lblLoginA.Text, 3, "INSERT nuevo usuario, User: " + tbAUsuario.Text);
                        MessageBox.Show
                           ("Usuario creado correctamente", "YEIH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show
                        ("Error al ingresar usuario, conctáctese con el administrador de la plataforma", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { }
        }
    }


    class Historial
    {
        string usuario { get; set; }
        string rol { get; set; }
        string fecha_consulta { get; set; }
        string parametros_consulta { get; set; }

        public Historial(string usuario, string rol, string fecha_consulta, string parametros_consulta)
        {
            this.usuario = usuario;
            this.rol = rol;
            this.fecha_consulta = fecha_consulta;
            this.parametros_consulta = parametros_consulta;
        }
    }
}
