using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_CV
{
    public class datosRegistro
    {
        public int id_Aspirante { get; set; }
        public string nombre_completo { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Objetivo { get; set; }
        public string Foto { get; set; }
        public string Ins_bachillerato { get; set; }
        public Nullable<System.DateTime> Fecha_inicio1 { get; set; }
        public Nullable<System.DateTime> Fecha_finalizacion1 { get; set; }
        public string Titulo_bto { get; set; }
        public string Departamento_bto { get; set; }
        public string Ins_universidad { get; set; }
        public Nullable<System.DateTime> Fecha_inicio2 { get; set; }
        public Nullable<System.DateTime> Fecha_finalizacion2 { get; set; }
        public string Titulo_uni { get; set; }
        public string Departamento_uni { get; set; }
        public string Habilidades { get; set; }
        public string Competencias { get; set; }
        public string Dominio { get; set; }
        public string Ref_nombre1 { get; set; }
        public Nullable<int> Ref_telefono1 { get; set; }
        public string Ref_tipo1 { get; set; }
        public string Ref_nombre2 { get; set; }
        public Nullable<int> Ref_telefono2 { get; set; }
        public string Ref_tipo2 { get; set; }
        public string Estado { get; set; }

        public void obtenerDatos()
        {
            nuevo_Registro nr = new nuevo_Registro();
            nr.txt_nombreCompleto.Text = nombre_completo;
        }
    }

    
}
