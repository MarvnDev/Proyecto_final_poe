using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_CV
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FormMenu menu = new FormMenu();
            menu.Show();
            //this.Close();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_NuevoAsp_Click(object sender, EventArgs e)
        {

        }
    }
}
