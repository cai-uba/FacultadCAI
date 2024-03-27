using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultadCAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtReporte_Click(object sender, EventArgs e)
        {

            
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificar form = new FormModificar();
            form.ShowDialog();
        }
    }
}
