using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;
using System.Configuration;

namespace Front
{
    public partial class Conexion : Form
    {
        public static SqlConnection con;
        public Conexion()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String server = txtServidor.Text;
            String dbName = txtBD.Text;
            String user = txtIS.Text;
            String pass = txtContraseña.Text;
            string cadena = "data source = " + server + "; initial catalog = " + dbName + "; user id = " + user + "; password = " + pass;
            con = new SqlConnection(cadena);
            try
            {
                con.Open();
                Menu menu = new Menu();
                menu.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error #" + ex.Number + " : " + ex.Message);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
