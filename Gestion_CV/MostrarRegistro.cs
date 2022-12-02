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
    public partial class MostrarRegistro : Form
    {
        public int? id;
        public MostrarRegistro(int? id = null)
        {
            InitializeComponent();
            
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void MostrarRegistro_Load(object sender, EventArgs e)
        {
        }
        private void CargarDatos()
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                Registro nuevo_registro = new Registro();
                nuevo_registro = db.Registros.Find(id);
                pictureBoxFoto.ImageLocation = nuevo_registro.Foto;
                lbl_nombre.Text = nuevo_registro.Nombre_completo;
                lbl_telefono.Text = nuevo_registro.Telefono.ToString();
                lbl_correo.Text = nuevo_registro.Email;
                lbl_dpto.Text = nuevo_registro.Departamento;
                lbl_Objective.Text = nuevo_registro.Objetivo;
                txt_Bachillerato.Text = nuevo_registro.Ins_bachillerato;
                txt_InicioBto.Text = nuevo_registro.Fecha_inicio1.ToString();
                txt_FinBto.Text = nuevo_registro.Fecha_finalizacion1.ToString();
                txt_BtoTitulo.Text = nuevo_registro.Titulo_bto;
                txt_BtoDepto.Text = nuevo_registro.Departamento_bto;
                txt_U.Text = nuevo_registro.Ins_universidad;
                txt_UDpto.Text = nuevo_registro.Ins_universidad;
                txt_inicioU.Text = nuevo_registro.Fecha_inicio2.ToString();
                txt_FinU.Text = nuevo_registro.Fecha_finalizacion2.ToString();
                txt_Utitulo.Text = nuevo_registro.Titulo_uni;
                txt_UDpto.Text = nuevo_registro.Departamento_uni;
                txt_Empresa.Text = nuevo_registro.exp_laboral;
                txt_Cargo.Text = nuevo_registro.cargo;
                txt_inicioTrabajo.Text = nuevo_registro.Fecha_inicio1.ToString();
                txt_finTrabajo.Text = nuevo_registro.Fecha_inicio2.ToString();
                txt_TDpto.Text = nuevo_registro.departamento_trabajo;
                txt_Dominio.Text = nuevo_registro.Dominio;
                txt_Habs.Text = nuevo_registro.Habilidades;
                txt_Comps.Text = nuevo_registro.Competencias;
                txt_Referencia1.Text = nuevo_registro.Ref_nombre1;
                txt_masked_telRef1.Text = nuevo_registro.Ref_telefono1.ToString();
                txt_tipoRef1.Text = nuevo_registro.Ref_tipo1;
                txt_Referencia2.Text = nuevo_registro.Ref_nombre2;
                txt_masked_telRef2.Text = nuevo_registro.Ref_telefono2.ToString();
                txt_tipoRef2.Text = nuevo_registro.Ref_tipo2;
            }
        }


    }
}
