using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_cargar_tipo1
    {
            private DataTable dt;
            public void fnt_CargarTipo1()
            {
                cls_cargar_tipo obj_Dt = new cls_cargar_tipo();
                obj_Dt.fnt_cargarTipo();
                this.dt = obj_Dt.getDt();
            }
            public DataTable getDt() { return dt; }
        
    }
}
