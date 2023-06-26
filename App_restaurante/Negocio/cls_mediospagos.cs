using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_mediospagos
    {
        private DataTable dt;
        public void fnt_mediopagos()
        {
            cls_mediopagos1 obj_Dt = new cls_mediopagos1();
            obj_Dt.ftn_mediopagos();
            this.dt = obj_Dt.getDt();
        }
        public DataTable getDt() { return dt; }
    }
}