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
using EntityFramework.Extensions;

namespace Gestion_CV
{
    public partial class VistaRRHH : Form
    {
        public VistaRRHH()
        {
            InitializeComponent();
        }

        private void VistaRRHH_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                    var listado = from data in db.Registros where data.Estado == "ACTIVO"
                                  select data;
                    dataGridViewRRHH.DataSource = listado.ToList();
            }

        }
        private int? Obtener_Id()
        {
            try
            {
                return int.Parse(dataGridViewRRHH.Rows[dataGridViewRRHH.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id = Obtener_Id();
            if (id != null)
            {
                using (CVGestionEntities db = new CVGestionEntities())
                {
                    Registro reg = new Registro();

                    Registro registros = db.Registros.Find(id);
                    registros.Estado = "INACTIVO";
                 
                    db.SaveChanges();
                    MessageBox.Show("REGISTRO ELIMINADO");
                }
            }
            MessageBox.Show("¡Registro eliminado exitosamente!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refrescar();
        }

        private void btn_accesoAdmin_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Show();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int? id = Obtener_Id();
            if(id!= null)
            {
                nuevo_Registro nr = new nuevo_Registro(id);
                nr.ShowDialog();
                
            }
            

                Refrescar();
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            int? id = Obtener_Id();
            if (id != null)
            {
                MostrarRegistro mr = new MostrarRegistro(id);
                mr.ShowDialog();

            }


            Refrescar();
        }
    }
}
