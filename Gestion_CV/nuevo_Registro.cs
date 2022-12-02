using System;
using System.Linq;
using System.IO;

using System.Windows.Forms;
using Gestion_CV.Modelo;

namespace Gestion_CV
{
    public partial class nuevo_Registro : Form
    {
        Registro _registro = new Registro();
        public int? id;
        Registro registros = null;


        string direccion_foto = "";
        public nuevo_Registro(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id!=null)
            {
                CargarDatos();
            }
        }

        //SELECCIONA IMAGEN
        private void btn_seleccionarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            string file = "";
            string foto_location = "C:\\Users\\tonyh\\OneDrive\\Escritorio\\GestiónCV_LAB_POE\\fotos_cv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                file = System.IO.Path.GetFileName(openFileDialog1.FileName);
                string direccion = System.IO.Path.Combine(foto_location, file);
                System.IO.File.Copy(openFileDialog1.FileName, direccion, true);
                direccion_foto = direccion;
            }
        }
        private void btn_MostrarRegistro_Click(object sender, EventArgs e)
        {
            MostrarRegistro mr = new MostrarRegistro();
            mr.pictureBoxFoto.Image = pictureBox1.Image;
            mr.lbl_nombre.Text = txt_nombreCompleto.Text;
            mr.lbl_telefono.Text = txt_masked_telAsp.Text;
            mr.lbl_correo.Text = txt_email.Text;
            mr.lbl_dpto.Text = comboBoxDepartamento.Text;
            mr.lbl_Objective.Text = txt_Objetivo.Text;
            mr.txt_Bachillerato.Text = txt_Bachillerato.Text;
            mr.txt_InicioBto.Text = dateTimePicker_Bto1.Value.ToString();
            mr.txt_FinBto.Text = dateTimePicker_Bto2.Value.ToString();
            mr.txt_BtoTitulo.Text = comboBox_btoTitulo.Text;
            mr.txt_BtoDepto.Text = comboBox_btoDepartamento.Text;
            mr.txt_U.Text = comboBoxUniversidades.Text;
            mr.txt_inicioU.Text = dateTimePicker_U1.Value.ToString();
            mr.txt_FinU.Text = dateTimePicker_U2.Value.ToString();
            mr.txt_Utitulo.Text = comboBox_Utitulo.Text;
            mr.txt_UDpto.Text = comboBox_UDepartamento.Text;
            mr.txt_Empresa.Text = txt_Empresa.Text;
            mr.txt_Cargo.Text = txt_Cargo.Text;
            mr.txt_inicioTrabajo.Text = dateTimePickerTrabajo1.Value.ToString();
            mr.txt_finTrabajo.Text = dateTimePickerTrabajo2.Value.ToString();
            mr.txt_TDpto.Text = comboBoxDptoTrabajo.Text;
            mr.txt_Dominio.Text = txt_Dominio.Text;
            mr.txt_Habs.Text = comboBox_Habilidades.Text;
            mr.txt_Comps.Text = comboBox_Competencias.Text;
            mr.txt_Referencia1.Text = txt_Referencia1.Text;
            mr.txt_masked_telRef1.Text = txt_masked_telRef1.Text;
            mr.txt_tipoRef1.Text = txt_tipoRef1.Text;
            mr.txt_Referencia2.Text = txt_Referencia2.Text;
            mr.txt_masked_telRef2.Text = txt_masked_telRef2.Text;
            mr.txt_tipoRef2.Text = txt_tipoRef2.Text;
            mr.ShowDialog();
        }

        //guarda los datos en la base de datos
        private void btn_GuardarRegistro_Click(object sender, EventArgs e)
        {
            
            using (CVGestionEntities db = new CVGestionEntities())
            {
                
                Registro nuevo_registro = new Registro();
                nuevo_registro.Foto = pictureBox1.ImageLocation;
                nuevo_registro.Nombre_completo = txt_nombreCompleto.Text;
                nuevo_registro.Telefono = int.Parse(txt_masked_telAsp.Text);
                nuevo_registro.Email = txt_email.Text;
                nuevo_registro.Departamento = comboBoxDepartamento.Text;
                nuevo_registro.Objetivo = txt_Objetivo.Text;
                nuevo_registro.Ins_bachillerato = txt_Bachillerato.Text;
                nuevo_registro.Fecha_inicio1 = dateTimePicker_Bto1.Value;
                nuevo_registro.Fecha_finalizacion1 = dateTimePicker_Bto2.Value;
                nuevo_registro.Titulo_bto = comboBox_btoTitulo.Text;
                nuevo_registro.Departamento_bto = comboBox_btoDepartamento.Text;
                nuevo_registro.Ins_universidad = comboBoxUniversidades.Text;
                nuevo_registro.Fecha_inicio2 = dateTimePicker_U1.Value;
                nuevo_registro.Fecha_finalizacion2 = dateTimePicker_U2.Value;
                nuevo_registro.Titulo_uni = comboBox_Utitulo.Text;
                nuevo_registro.Departamento_uni = comboBox_UDepartamento.Text;
                nuevo_registro.exp_laboral = txt_Empresa.Text;
                nuevo_registro.cargo = txt_Cargo.Text;
                nuevo_registro.inicio_cargo = dateTimePickerTrabajo1.Value;
                nuevo_registro.fin_cargo = dateTimePickerTrabajo2.Value;
                nuevo_registro.departamento_trabajo = comboBoxDptoTrabajo.Text;
                nuevo_registro.Dominio = txt_Dominio.Text;
                nuevo_registro.Habilidades = comboBox_Habilidades.Text;
                nuevo_registro.Competencias = comboBox_Competencias.Text;
                nuevo_registro.Ref_nombre1 = txt_Referencia1.Text;
                nuevo_registro.Ref_telefono1 = int.Parse(txt_masked_telRef1.Text);
                nuevo_registro.Ref_tipo1 = txt_tipoRef1.Text;
                nuevo_registro.Ref_nombre2 = txt_Referencia2.Text;
                nuevo_registro.Ref_telefono2 = int.Parse(txt_masked_telRef2.Text);
                nuevo_registro.Ref_tipo2 = txt_tipoRef2.Text;

                nuevo_registro.Estado = "ACTIVO";

                db.Registros.Add(nuevo_registro);
                db.SaveChanges();

                MessageBox.Show("¡Todos los datos han sido agregados exitosamente!","ÉXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //CARGAR DATOS PARA EDITAR
        private void CargarDatos()
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                Registro nuevo_registro = new Registro();
                nuevo_registro = db.Registros.Find(id);
                pictureBox1.ImageLocation = nuevo_registro.Foto;
                txt_nombreCompleto.Text = nuevo_registro.Nombre_completo;
                txt_masked_telAsp.Text = nuevo_registro.Telefono.ToString();
                txt_email.Text = nuevo_registro.Email;
                comboBoxDepartamento.Text = nuevo_registro.Departamento; 
                txt_Objetivo.Text = nuevo_registro.Objetivo;
                txt_Bachillerato.Text = nuevo_registro.Ins_bachillerato;
                dateTimePicker_Bto1.Value = (DateTime)nuevo_registro.Fecha_inicio1;
                dateTimePicker_Bto2.Value = (DateTime)nuevo_registro.Fecha_finalizacion1;
                comboBox_btoTitulo.Text = nuevo_registro.Titulo_bto;
                comboBox_btoDepartamento.Text = nuevo_registro.Departamento_bto;
                comboBoxUniversidades.Text = nuevo_registro.Ins_universidad;
                dateTimePicker_U1.Value = (DateTime)nuevo_registro.Fecha_inicio2;
                dateTimePicker_U2.Value = (DateTime)nuevo_registro.Fecha_finalizacion2;
                comboBox_Utitulo.Text = nuevo_registro.Titulo_uni;
                comboBox_UDepartamento.Text = nuevo_registro.Departamento_uni;
                txt_Empresa.Text = nuevo_registro.exp_laboral;
                txt_Cargo.Text = nuevo_registro.cargo;
                dateTimePickerTrabajo1.Value = (DateTime)nuevo_registro.Fecha_inicio1;
                dateTimePickerTrabajo2.Value = (DateTime)nuevo_registro.Fecha_inicio2;
                comboBoxDptoTrabajo.Text = nuevo_registro.departamento_trabajo;
                txt_Dominio.Text = nuevo_registro.Dominio;
                comboBox_Habilidades.Text = nuevo_registro.Habilidades;
                comboBox_Competencias.Text = nuevo_registro.Competencias;
                txt_Referencia1.Text = nuevo_registro.Ref_nombre1;
                txt_masked_telRef1.Text = nuevo_registro.Ref_telefono1.ToString();
                txt_tipoRef1.Text = nuevo_registro.Ref_tipo1;
                txt_Referencia2.Text = nuevo_registro.Ref_nombre2;
                txt_masked_telRef2.Text = nuevo_registro.Ref_telefono2.ToString();
                txt_tipoRef2.Text = nuevo_registro.Ref_tipo2;
                

            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                nuevo_Registro nr = new nuevo_Registro();
                Registro reg = db.Registros.FirstOrDefault(x => x.id_Aspirante == id);
                reg.Foto = pictureBox1.ImageLocation;
                reg.Nombre_completo = txt_nombreCompleto.Text;
                reg.Telefono = int.Parse(txt_masked_telAsp.Text);
                reg.Email = txt_email.Text;
                reg.Departamento = comboBoxDepartamento.Text;
                reg.Objetivo = txt_Objetivo.Text;
                reg.Ins_bachillerato = txt_Bachillerato.Text;
                reg.Fecha_inicio1 = dateTimePicker_Bto1.Value;
                reg.Fecha_finalizacion1 = dateTimePicker_Bto2.Value;
                reg.Titulo_bto = comboBox_btoTitulo.Text;
                reg.Departamento_bto = comboBox_btoDepartamento.Text;
                reg.Ins_universidad = comboBoxUniversidades.Text;
                reg.Fecha_inicio2 = dateTimePicker_U1.Value;
                reg.Fecha_finalizacion2 = dateTimePicker_U2.Value;
                reg.Titulo_uni = comboBox_Utitulo.Text;
                reg.Departamento_uni = comboBox_UDepartamento.Text;
                reg.exp_laboral = txt_Empresa.Text;
                reg.cargo = txt_Cargo.Text;
                reg.Fecha_inicio1 = dateTimePickerTrabajo1.Value;
                reg.Fecha_inicio2 = dateTimePickerTrabajo2.Value;
                reg.departamento_trabajo = comboBoxDptoTrabajo.Text;
                reg.Dominio = txt_Dominio.Text;
                reg.Habilidades = comboBox_Habilidades.Text;
                reg.Competencias = comboBox_Competencias.Text;
                reg.Ref_nombre1 = txt_Referencia1.Text;
                reg.Ref_telefono1 = int.Parse(txt_masked_telRef1.Text);
                reg.Ref_tipo1 = txt_tipoRef1.Text;
                reg.Ref_nombre2 = txt_Referencia2.Text;
                reg.Ref_telefono2 = int.Parse(txt_masked_telRef2.Text);
                reg.Ref_tipo2 = txt_tipoRef2.Text;
                db.SaveChanges();
            }
        }
           
    }
}
