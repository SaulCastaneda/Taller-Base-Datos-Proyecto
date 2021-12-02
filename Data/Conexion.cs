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
            //Conexion Casa
            string strConn = "LAPTOP-0OKHORIS\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conn;
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
