using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Actualizar_Personal
    {
        private string str_Id;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Correo;
        private string str_msn;

        public cls_Actualizar_Personal(string Id, string Nombre, string Contacto, string Correo) 
        {
        this.str_Id = Id;
        this.str_Nombre = Nombre;
        this.str_Contacto = Contacto;
        this.str_Correo = Correo;

            if (str_Id == "" || str_Nombre == "" || str_Contacto == "" || str_Correo == "")
            {
                str_msn = "DEBE INGRESAR TODA LA INFORMACION REQUERIDA";
            }
            else 
            {
                cls_Funciones_Personal objActualizar = new cls_Funciones_Personal();
                objActualizar.fnt_Actualizar
                    (str_Id, str_Nombre,     str_Contacto,str_Correo);
                str_msn = "EL CLIENTE " + str_Nombre + " HA SIDO ACTUALIZADO";
            }
      
        }
        public string getMsn() { return str_msn; }
    }
}
