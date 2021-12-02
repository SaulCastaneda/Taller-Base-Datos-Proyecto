using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Consulta : Form
    { 
        public Consulta()

        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender,EventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;
            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);

        }

        void CargarTabla(string clave, string nombre, string contact, string title, string address, string city, string region, string postal, string country, string phone, string fax, string home)
        {
            try
            {
                DataTable data = Negocios.NSuppliers.ObtenSuppliersFiltro(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
                this.dgvShippers.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtContactName_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtCity_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtRegion_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtPostal_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtCountry_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtFax_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }

        private void txtHome_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            string nombre = txtNombre.Text;
            string contact = txtContactName.Text;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postal = txtPostal.Text;
            string country = txtCountry.Text;
            string phone = txtTelefono.Text;
            string fax = txtFax.Text;
            string home = txtHome.Text;

            CargarTabla(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
        }
    }
}
