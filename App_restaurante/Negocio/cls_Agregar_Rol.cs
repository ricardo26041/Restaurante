using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class cls_Agregar_Rol
    {
        private DataTable dt;
        public void fnt_CargarRo1()
        {
            cls_Cargar_Rol obj_Dt = new cls_Cargar_Rol();
            obj_Dt.fnt_CargarRol();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}
