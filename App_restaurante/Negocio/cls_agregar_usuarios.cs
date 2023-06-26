using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agregar_usuarios
    {
        private string str_usuario;
        private string str_contraseña;
        private string str_id;
        private int int_estado;
        private int int_rol;
        private string str_msn;

        public cls_agregar_usuarios(string usuario, string contraseña, string id, int estado, int rol)
        {
            this.str_usuario = usuario;
            this.str_contraseña = contraseña;
            this.str_id = id;
            this.int_estado = estado;
            this.int_rol = rol;

            cls_Funciones_Usuarios objGuardar = new cls_Funciones_Usuarios();
            objGuardar.fnt_guardar(str_usuario, str_contraseña, str_id, int_estado, int_rol);
            str_msn = "  EL USUARIO CON EL DOCUMENTO" + str_id + " HA SIDO REGISTRADO CON EXITO ";
        }
        public string getMsn() { return this.str_msn; }

    }
}
