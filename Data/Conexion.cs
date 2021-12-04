using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaBD;

namespace Data
{
    public class Conexion
    {
       
            public static SqlConnection CrearConexion()
            {
                //Conexion BRANDON
               // string strConn = "Data Source=DESKTOP-0Q81B2R;Initial Catalog=Northwind;Integrated Security=True";
                //CONEXION SAUL
                string strConn = "Data Source=LAPTOP-0OKHORIS;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection conn= new SqlConnection();
                try
                {
                    conn = UsoBD.ConectaBD(strConn);
                }
                catch (Exception ex)
                {
                    conn = null;
                    throw ex;
                }
                return conn;
            }
        
        

        

    }    
       
    
}
