using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Actualizar_Clientes
    {
        private string str_Id;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Direccion;
        private string str_msn;

        public cls_Actualizar_Clientes(string Id, string Nombres, string Contacto, string Direccion)
        {
            this.str_Id = Id;
            this.str_Nombre = Nombres;
            this.str_Contacto = Contacto;
            this.str_Direccion = Direccion;

            if (str_Id == "" || str_Nombre == "" || str_Contacto == "" ||
                str_Direccion == "")

            {
                str_msn = "DEBE INGRESAR TODA LA INFORMACION REQUERIDA";
            }
            else
            {
                cls_Funciones_Clientes1 objActualizar = new cls_Funciones_Clientes1();
                objActualizar.fnt_Actualizar
                    (str_Id, str_Nombre, str_Contacto, str_Direccion);
                str_msn = "EL CLIENTE " + str_Nombre + " HA SIDO ACTUALIZADO";
            }
        }
        public string getMsn() { return str_msn; }
    }
}
