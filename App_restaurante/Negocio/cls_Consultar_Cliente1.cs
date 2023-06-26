using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Consultar_Cliente1
    {
        private string str_nombre;
        private string str_Contacto;
        private string str_direccion;
        private string str_msn;
        public void fnt_Consultar(string id)
        {
        if (id == "") 
            {
                str_msn = "DEBE INGRESAR LA IDENTIFICACION DEL CLIENTE";
            }
            else 
            {
            Datos.cls_Consultar_Clientes obj_Consultar = new Datos.cls_Consultar_Clientes();
                obj_Consultar.fnt_ConsultarCliente(id);
                str_nombre = obj_Consultar.getNombre();
                str_Contacto = obj_Consultar.getContacto();
                str_direccion = obj_Consultar.getDireccion();
                str_msn = obj_Consultar.getMsn();
            }
        }
        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_Contacto; }
        public string getDireccion() { return this.str_direccion; }
        public string getMsn() { return this.str_msn; }
    }
}
