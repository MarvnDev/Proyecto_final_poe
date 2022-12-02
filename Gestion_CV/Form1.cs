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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo_Registro f = new nuevo_Registro();
            f.ShowDialog();
            this.Close();

        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }
    }
}
