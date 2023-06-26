using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_actualizar_usuario
    {
        private string str_id;
        private int int_estado;
        private int int_rol;

        public cls_actualizar_usuario(string id, int estado, int rol) 
        {
            this.str_id = id;
            this.int_estado = estado;
            this.int_rol = rol;

            cls_Funciones_Usuarios objActualizar = new cls_Funciones_Usuarios();
            objActualizar.fnt_Actualizar(str_id, int_estado, int_rol);
        }
              
    }
}
