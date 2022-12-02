using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_CV.Modelo;

namespace Gestion_CV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            string contra = Encrypt.sha256(txt_contra.Text);
            using (CVGestionEntities db = new CVGestionEntities())
            {
                var soloAdmin = from data in db.Usuarios
                                where data.usuario1 == "admin"
                                && data.pass_enc == contra
                                select data;

                if (soloAdmin.ToList().Count() > 0)
                {
                    VistaAdmin va = new VistaAdmin();
                    va.ShowDialog();
                }
                else if (Validacion_User(txt_usuario.Text, contra))
                {
                    this.Hide();
                    // MessageBox.Show("ACCEDIENDO.....");
                    FormMenuSup msup = new FormMenuSup();
                    msup.Show();

                }
                else
                    MessageBox.Show("El usuario y/o contraseña son incorrectos.");
            }
        }
        private bool Validacion_User(string usuario, string contra)
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {

                return db.sp_validacion_user(usuario, contra).ToList().Count()>0;
                    
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
