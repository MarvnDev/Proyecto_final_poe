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
    public partial class FormMenuSup : Form
    {
        public FormMenuSup()
        {
            InitializeComponent();
        }

        private void btn_NuevoAsp_Click(object sender, EventArgs e)
        {
            VistaRRHH vr = new VistaRRHH();
            vr.MdiParent = this;
            vr.Show();
        }
    }
}
