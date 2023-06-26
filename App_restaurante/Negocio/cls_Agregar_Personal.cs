using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Agregar_Personal
    {
        private string str_Id;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Correo;
        private string str_msn;

        public cls_Agregar_Personal(string str_Id, string str_Nombre, string str_Contacto, string str_Correo)
        {
            this.str_Id = str_Id;
            this.str_Nombre = str_Nombre;
            this.str_Contacto = str_Contacto;
            this.str_Correo = str_Correo;
            if (str_Id == "" || str_Nombre == "" || str_Contacto == "" || str_Correo == "")
            {
                str_msn = "DEBE INGRESAR LA INFORMACION SOLICITADA";
            }
            else
            {
                cls_Funciones_Personal objGuardar = new cls_Funciones_Personal();
                objGuardar.fnt_Guardar(str_Id, str_Nombre, str_Contacto, str_Correo);
                str_msn = " EL CLIENTE " + str_Nombre + " HA SIDO REGISTRADO CON EXITO ";
            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
