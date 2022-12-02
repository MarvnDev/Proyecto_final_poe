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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_NuevoAsp_Click(object sender, EventArgs e)
        {
            nuevo_Registro nr = new nuevo_Registro();
            nr.MdiParent = this;
            nr.Show();
            
        }


        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_VistaRRHH_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            //VistaRRHH vr = new VistaRRHH();
            this.Hide();
            log.Show();
            
        }


    }
}
