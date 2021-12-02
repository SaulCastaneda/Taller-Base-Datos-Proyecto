using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.ShowDialog();
        }

        private void btnCaptura_Click(object sender, EventArgs e)

        {
            
            Agregar ag = new Agregar();
            ag.ShowDialog();
          
        }
    }
}
