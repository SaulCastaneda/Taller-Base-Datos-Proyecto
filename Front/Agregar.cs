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
using Entidades;
using Negocios;

namespace Front
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = Negocios.NSuppliers.ObtenSuppliers();
                this.dgvShippers.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtContactName.Text = "";
            txtCountry.Text = "";
            txtFax.Text = "";
            txtHome.Text = "";
            txtNombre.Text = "";
            txtPostal.Text = "";
            txtRegion.Text = "";
            txtTelefono.Text = "";
            txtTitle.Text = "";
            txtID.Enabled = true;
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtID.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string clave;

            if (rbNuevo.Checked)
            {
                //string clave = txtID.Text;
                string nombre = txtNombre.Text;
                if (!validaTexto(nombre))
                {
                    MessageBox.Show("Campo NOMBRE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string contact = txtContactName.Text;
                if (!validaTexto(contact))
                {
                    MessageBox.Show("Campo CONTACT NAME Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string title = txtTitle.Text;
                if (!validaTexto(title))
                {
                    MessageBox.Show("Campo CONTACT TITLE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string address = txtAddress.Text;
                if (!validaTexto(address))
                {
                    MessageBox.Show("Campo ADRESS Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string city = txtCity.Text;
                if (!validaTexto(city))
                {
                    MessageBox.Show("Campo CITY Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string region = txtRegion.Text;
                if (!validaTexto(region))
                {
                    MessageBox.Show("Campo REGION Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string postal = txtPostal.Text;
                if (!validaTexto(postal))
                {
                    MessageBox.Show("Campo POSTAL CODE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string country = txtCountry.Text;
                if (!validaTexto(country))
                {
                    MessageBox.Show("Campo COUNTRY Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string phone = txtTelefono.Text;
                if (!validaTexto(phone))
                {
                    MessageBox.Show("Campo PHONE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string fax = txtFax.Text;
                if (!validaTexto(fax))
                {
                    MessageBox.Show("Campo FAX Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string home = txtHome.Text;
                if (!validaTexto(home))
                {
                    MessageBox.Show("Campo HOMEPAGE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    clave = NSuppliers.Agregar(nombre, contact, title, address, city, region, postal, country, phone, fax, home);
                    this.txtID.Text = clave;
                    MessageBox.Show("" + clave);
                    Agregar_Load(e, e);
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
               
            }
            if (rbUpdate.Checked)
            {
                 clave = txtID.Text;
                if (!validaTexto(clave))
                {
                    MessageBox.Show("Campo SUPPLIERID Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string nombre = txtNombre.Text;
                if (!validaTexto(nombre))
                {
                    MessageBox.Show("Campo NOMBRE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string contact = txtContactName.Text;
                if (!validaTexto(contact))
                {
                    MessageBox.Show("Campo CONTACT NAME Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string title = txtTitle.Text;
                if (!validaTexto(title))
                {
                    MessageBox.Show("Campo CONTACT TITLE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string address = txtAddress.Text;
                if (!validaTexto(address))
                {
                    MessageBox.Show("Campo ADRESS Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string city = txtCity.Text;
                if (!validaTexto(city))
                {
                    MessageBox.Show("Campo CITY Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string region = txtRegion.Text;
                if (!validaTexto(region))
                {
                    MessageBox.Show("Campo REGION Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string postal = txtPostal.Text;
                if (!validaTexto(postal))
                {
                    MessageBox.Show("Campo POSTAL CODE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string country = txtCountry.Text;
                if (!validaTexto(country))
                {
                    MessageBox.Show("Campo COUNTRY Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string phone = txtTelefono.Text;
                if (!validaTexto(phone))
                {
                    MessageBox.Show("Campo PHONE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string fax = txtFax.Text;
                if (!validaTexto(fax))
                {
                    MessageBox.Show("Campo FAX Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string home = txtHome.Text;
                if (!validaTexto(home))
                {
                    MessageBox.Show("Campo HOMEPAGE Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                  NSuppliers.Update(clave, nombre, contact, title, address, city, region, postal, country, phone, fax, home);
                  Agregar_Load(e, e);
                  Limpiar();
                }
                catch
                {
                    MessageBox.Show("Error al realizar la actualizacion");
                    return;
                }

            }
        }

        void Limpiar()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtContactName.Text = "";
            txtCountry.Text = "";
            txtFax.Text = "";
            txtHome.Text = "";
            txtNombre.Text = "";
            txtPostal.Text = "";
            txtRegion.Text = "";
            txtTelefono.Text = "";
            txtTitle.Text = "";
        }

        public bool validaTexto(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena))
                return false;
            return true;
        }

        public void SelectSuppliers(string clave)
        {
            string[] suppliers = NSuppliers.SelectSuppliers(clave);
            txtID.Text = suppliers[0];
            txtNombre.Text = suppliers[1];
            txtContactName.Text = suppliers[2];
            txtTitle.Text = suppliers[3];
            txtAddress.Text = suppliers[4];
            txtCity.Text = suppliers[5];
            txtRegion.Text = suppliers[6];
            txtPostal.Text = suppliers[7];
            txtCountry.Text = suppliers[8];
            txtTelefono.Text = suppliers[9];
            txtFax.Text = suppliers[10];
            txtHome.Text = suppliers[11];
            
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtID.Text;
            SelectSuppliers(clave);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
