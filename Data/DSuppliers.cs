using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Data
{
    public class DSuppliers
    {

        public static DataTable ObtenSuppliers()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                string strComand = "select * from Suppliers";
                SqlCommand cmd = new SqlCommand(strComand, conn);
                lector = cmd.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                   conn.Close();
                }
            }
        }

        public static string []  SelectSuppliers(string clave)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;
            
                conn = Conexion.CrearConexion();
                string strComand = "select * from Suppliers where SupplierID = '"+clave+"'";
                SqlCommand cmd = new SqlCommand(strComand, conn);
            string[] sup = new string[12];
            try 
            {     
            lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        sup[0] = lector.GetValue(0).ToString();
                        sup[1] = lector.GetValue(1).ToString();
                        sup[2] = lector.GetValue(2).ToString();
                        sup[3] = lector.GetValue(3).ToString();
                        sup[4] = lector.GetValue(4).ToString();
                        sup[5] = lector.GetValue(5).ToString();
                        sup[6] = lector.GetValue(6).ToString();
                        sup[7] = lector.GetValue(7).ToString();
                        sup[8] = lector.GetValue(8).ToString();
                        sup[9] = lector.GetValue(9).ToString();
                        sup[10] = lector.GetValue(10).ToString();
                        sup[11] = lector.GetValue(11).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return sup;
        }

        public static DataTable ObtenSuppliersFiltro(string clave, string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;
            string select = null;

            select = "Select * from Suppliers where 1 = 1";

            if (!clave.Equals(""))
            {
                select = select + " and SupplierID = " + clave;
            }
            if (!nombre.Equals(""))
            {
                select = select + " and CompanyName like '%" + nombre + "%'";
            }
            if (!contact.Equals(""))
            {
                select = select + " and ContactName like '%" + contact + "%'";
            }
            if (!title.Equals(""))
            {
                select = select + " and ContactTitle like '%" + title + "%'";
            }
            if (!address.Equals(""))
            {
                select = select + " and Address like '%" + address + "%'";
            }
            if (!city.Equals(""))
            {
                select = select + " and City like '%" + city + "%'";
            }
            if (!region.Equals(""))
            {
                select = select + " and Region like '%" + region + "%'";
            }
            if (!postal.Equals(""))
            {
                select = select + " and PostalCode like '%" + postal + "%'";
            }
            if (!country.Equals(""))
            {
                select = select + " and Country like '%" + country + "%'";
            }
            if (!phone.Equals(""))
            {
                select = select + " and Phone like '%" + phone + "%'";
            }
            if (!fax.Equals(""))
            {
                select = select + " and Fax like '%" + fax + "%'";
            }
            if (!home.Equals(""))
            {
                select = select + " and HomePage like '%" + home + "%'";
            }

            try
            {
                conn = Conexion.CrearConexion();
                string strComand = select;
                SqlCommand cmd = new SqlCommand(strComand, conn);
                lector = cmd.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static string Agregar(string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
            SqlConnection conn = null;
            string Rpta = "";
            string exep = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Suppliers", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = contact;
                comando.Parameters.Add("@ContactTitle", SqlDbType.VarChar).Value = title;
                comando.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
                comando.Parameters.Add("@City", SqlDbType.VarChar).Value = city;
                comando.Parameters.Add("@Region", SqlDbType.VarChar).Value = region;
                comando.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = postal;
                comando.Parameters.Add("@Country", SqlDbType.VarChar).Value = country;
                comando.Parameters.Add("@Phone", SqlDbType.VarChar).Value = phone;
                comando.Parameters.Add("@Fax", SqlDbType.VarChar).Value = fax;
                comando.Parameters.Add("@Homepage", SqlDbType.VarChar).Value = home;
                SqlParameter clave = new SqlParameter();
                clave.ParameterName = "@SupplierID";
                clave.SqlDbType = SqlDbType.Int;
                clave.Direction = ParameterDirection.Output;
                comando.Parameters.Add(clave);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(clave.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }

        public static string Update(string clave, string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Suppliers", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@SupplierID", SqlDbType.VarChar).Value = clave;
                comando.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = contact;
                comando.Parameters.Add("@ContactTitle", SqlDbType.VarChar).Value = title;
                comando.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
                comando.Parameters.Add("@City", SqlDbType.VarChar).Value = city;
                comando.Parameters.Add("@Region", SqlDbType.VarChar).Value = region;
                comando.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = postal;
                comando.Parameters.Add("@Country", SqlDbType.VarChar).Value = country;
                comando.Parameters.Add("@Phone", SqlDbType.VarChar).Value = phone;
                comando.Parameters.Add("@Fax", SqlDbType.VarChar).Value = fax;
                comando.Parameters.Add("@Homepage", SqlDbType.VarChar).Value = home;
                comando.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }

    }
}
