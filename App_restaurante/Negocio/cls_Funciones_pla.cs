using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class cls_Funciones_pla
    {
        private string str_nombre;
        private string str_ingredientes;
        private int int_ValorU;
        private string str_msn;
        public void fnt_Consultarplatos(string Codigo) 
        {
            if (Codigo == "") 
            {
                str_msn = "DEBE INGRESAR LA IDENTIFICACION DEL PLATO";
            }
            else 
            {
            Datos.cls_Funciones_Platos obj_Consulta = new Datos.cls_Funciones_Platos();
                obj_Consulta.fnt_Consultarplatos(Codigo);
                str_nombre = obj_Consulta.getNombre();
                str_ingredientes = obj_Consulta.getIngredientes();
                int_ValorU = obj_Consulta.getprecio();
                str_msn = obj_Consulta.getMensaje();
            }
        }
        public string getNombre() { return str_nombre; }
        public string getIngredientes() {  return str_ingredientes; }
        public int getValorU() { return int_ValorU; }
        public string getmensaje() { return str_msn; }
    }
}
