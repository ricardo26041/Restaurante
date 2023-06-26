using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Agregar_Clientes
    {
        private string str_Id;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Direccion;
        private string str_msn;
       

        public cls_Agregar_Clientes(string str_Id, string str_Nombre, string str_Contacto, string str_Direccion)

        {
            this.str_Id = str_Id;
            this.str_Nombre = str_Nombre;
            this.str_Contacto = str_Contacto;
            this.str_Direccion = str_Direccion;
            if (str_Id == "" || str_Nombre == "" || str_Contacto == "" || str_Direccion == "")
            {
                str_msn = "DEBE INGRESAR LA INFORMACION SOLICITADA";
            }
            else
            {
                cls_Funciones_Clientes1 objGuardar = new cls_Funciones_Clientes1();
                objGuardar.fnt_GuardarC(str_Id, str_Nombre, str_Contacto, str_Direccion);
                str_msn = " EL CLIENTE " + str_Nombre+ " HA SIDO REGISTRADO CON EXITO ";

            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
