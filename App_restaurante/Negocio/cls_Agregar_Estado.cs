using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Agregar_Estado
    {
        private DataTable dt;
        public void fnt_Estado()
        {
            cls_estado obj_Dt = new cls_estado();
            obj_Dt.fnt_Estado();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}
