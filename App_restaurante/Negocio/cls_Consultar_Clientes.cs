using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Consultar_Clientes
    {
        private Bitmap bmp;
        private string str_Id;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Direccion;

        public void fnt_Consultar1(string Id)
        {
            cls_Funciones_Clientes1 obj_consultar = new cls_Funciones_Clientes1();
            obj_consultar.fnt_Consultar1(Id);
            this.str_Nombre = obj_consultar.getNombre();
            this.str_Contacto = obj_consultar.getContacto();
            this.str_Direccion = obj_consultar.getDireccion();
        }
        public Bitmap getBmp() { return bmp; }
        public string getNombre() { return this.str_Nombre; }
        public string getContacto() { return this.str_Contacto; }
        public string getDireccion() { return this.str_Direccion; }

    }
}   
