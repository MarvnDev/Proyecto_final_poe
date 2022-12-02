using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_CV.Modelo;

namespace Gestion_CV
{
    /// <summary>
    /// EN ESTE FORMULARIO SE ENCUENTRA TODA LA LÓGICA
    /// DE LA VISTA DE ADMINISTRADOR
    /// </summary>
     
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void VistaAdmin_Load(object sender, EventArgs e)
        {
            //----CADA VEZ QUE SE CARGUE EL FORMULARIO LA GRID
            //----SE REFRESCARÁ
            Refrescar(); 
        }
        
        //MÉTODO QUE HACE QUE LA GRID SE REFRESQUE LUEGO DE CADA
        //CAMBIO EFECTUADO
        private void Refrescar()
        {
            //SE ACCEDE A LA ENTIDAD
            using (CVGestionEntities db = new CVGestionEntities())
            {
                //ESTABLECEMOS DE DONDE SERÁ EL ORIGEN DE LOS DATOS 
                var listado = from data in db.Registros
                              select data;
                dataGridViewAdmin.DataSource = listado.ToList();
            }
             
        }


        //METODO QUE HACE QUE AL SELECCIONAR LA FILA DE LA GRID SE
        //OBTENGA LA ID DEL REGISTRO
        private int? Obtener_Id()
        {
            try
            {
                return int.Parse(dataGridViewAdmin.Rows[dataGridViewAdmin.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }


        //PROCESO PARA ELIMINAR DEFINITIVAMENTE UN REGISTRO DE LA BASE
        private void button1_Click(object sender, EventArgs e)
        {
            int? id = Obtener_Id(); // OBTENEMOS EL ID
            if (id != null) //ESTABLECEMOS LA CONDICIÓN
            {
                using (CVGestionEntities db = new CVGestionEntities())
                {
                    Registro registros = db.Registros.Find(id);
                    db.Registros.Remove(registros);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("¡Registro eliminado definitivamente!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refrescar();
        }

        //PROCESO PARA RECUPERAR UN REGISTRO ( INACTIVO>>ACTIVO )
        private void btn_Recuperar_Click(object sender, EventArgs e)
        {
            int? id = Obtener_Id();
            if (id != null)
            {
                using (CVGestionEntities db = new CVGestionEntities())
                {
                    Registro reg = new Registro();

                    Registro registros = db.Registros.Find(id);
                    registros.Estado = "ACTIVO";

                    db.SaveChanges();
                    MessageBox.Show("REGISTRO RECUPERADO");
                }
            }
            MessageBox.Show("¡Registro recuperado exitosamente!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refrescar();
        }


        //MÉTODO PARA REALIZAR LOS FILTROS
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                if (radioButtonDptos.Checked == true)
                    dataGridViewAdmin.DataSource = db.Registros.Where(x => x.Departamento == comboBox_Filtro.Text).ToList();
                
                else if(radioButtonHabs.Checked == true)
                    dataGridViewAdmin.DataSource = db.Registros.Where(x => x.Habilidades  == comboBox_Filtro.Text).ToList();
                
                else if (radioButtonComps.Checked == true)
                    dataGridViewAdmin.DataSource = db.Registros.Where(x => x.Competencias == comboBox_Filtro.Text).ToList();
            }
        }

        //LLENAR EL COMBOBOX CON LOS DATOS REQUERIDOS
        private void radioButtonDptos_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Filtro.Items.Clear();
            comboBox_Filtro.Items.Add("Sonsonate");
            comboBox_Filtro.Items.Add("Santa Ana");
            comboBox_Filtro.Items.Add("La Libertad");
            comboBox_Filtro.Items.Add("Chalatenango");
            comboBox_Filtro.Items.Add("Ahuachapan");
            comboBox_Filtro.Items.Add("La Paz");
            comboBox_Filtro.Items.Add("San Salvador");
            comboBox_Filtro.Items.Add("Cuscatlán");
            comboBox_Filtro.Items.Add("Cabañas");
            comboBox_Filtro.Items.Add("San Vicente");
            comboBox_Filtro.Items.Add("Usulutan");
            comboBox_Filtro.Items.Add("San Miguel");
            comboBox_Filtro.Items.Add("Morazán");
            comboBox_Filtro.Items.Add("La Unión");
        }

        private void radioButtonHabs_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Filtro.Items.Clear();
            comboBox_Filtro.Items.Add("Comunicación");
            comboBox_Filtro.Items.Add("Escucha Activa");
            comboBox_Filtro.Items.Add("Amabilidad");
            comboBox_Filtro.Items.Add("Memoria");
            comboBox_Filtro.Items.Add("Percepción");
            comboBox_Filtro.Items.Add("Creatividad");
            comboBox_Filtro.Items.Add("Gestión del estrés");
            comboBox_Filtro.Items.Add("Adaptación");
            comboBox_Filtro.Items.Add("Liderazgo");
            comboBox_Filtro.Items.Add("Trabajo en Equipo");
        }

        private void radioButtonComps_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Filtro.Items.Clear();
            comboBox_Filtro.Items.Add("Aprendizaje");
            comboBox_Filtro.Items.Add("Gestión de la información");
            comboBox_Filtro.Items.Add("Inteligencia social");
            comboBox_Filtro.Items.Add("Lealtad");
            comboBox_Filtro.Items.Add("Toma de decisiones");
            comboBox_Filtro.Items.Add("Compromiso");
            comboBox_Filtro.Items.Add("Alta Productividad");
            comboBox_Filtro.Items.Add("Flexibilidad");

        }

        //PROCESO DE FILTRADO POR TEXTBOX
        private void btn_otroFiltro_Click(object sender, EventArgs e)
        {
            using (CVGestionEntities db = new CVGestionEntities())
            {
                var query = from data in db.Registros
                            where data.Nombre_completo.Contains(txt_otroFiltrado.Text)
                            select data;
                dataGridViewAdmin.DataSource = query.ToList();

            } 
        }


        //sha256
    }
}
