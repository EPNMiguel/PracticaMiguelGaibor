using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMiguelGaibor
{
    public class Log
    {
        private static Log instance = null;
     private Log() { }  

        public static Log getInstance()
        {
             
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
             
        }

        public   void logea(string user, int rol, string parametros)
        {
            try
            {
                string conection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\A\\source\\repos\\PracticaMiguelGaibor\\PracticaMiguelGaibor\\AppData\\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(conection);
                conn.Open();
                String queryInsert = "insert into historial  ( USUARIO , rol , fecha_consulta , parametros_consulta) values ('" + user + "', " + rol + " , getdate() , '" + parametros + "') ";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
    }
}
