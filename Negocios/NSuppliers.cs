using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data;
using System.Data;
using Entidades;

namespace Negocios
{
    public class NSuppliers
    {
        public static DataTable ObtenSuppliersFiltro(string clave, string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home) => DSuppliers.ObtenSuppliersFiltro(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);

        public static DataTable ObtenSuppliers()
        {
            return DSuppliers.ObtenSuppliers();
        }

        public static string Agregar(string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
             string clave = DSuppliers.Agregar(nombre, contact, title, address, city, region, postal, country, phone, fax, home);
             return clave;
        }

        public static string Update(string clave,string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
            return DSuppliers.Update(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
            
        }

        public static string [] SelectSuppliers(string clave)
        {
            return DSuppliers.SelectSuppliers(clave);
            
        }

       
    }
}
