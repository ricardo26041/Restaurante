using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_cargar_estado1
    {
        private DataTable dt;
        public void fnt_CargarEstado1()
        {
            cls_cargar_estado obj_Dt = new cls_cargar_estado();
            obj_Dt.fnt_cargarEstado();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}
