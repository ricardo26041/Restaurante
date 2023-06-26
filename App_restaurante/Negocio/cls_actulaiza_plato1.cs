using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Negocio
{
    public class cls_actulaiza_plato1
    {
        private string str_Codigo;
        private string str_nombres;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private string str_msn; // envia msj a la capa de presentacion


        public cls_actulaiza_plato1(string codigo, string nombres, string ingredientes, string valor, int tipo, int estado)
        {
            this.str_Codigo = codigo;
            this.str_nombres = nombres;
            this.str_ingredientes = ingredientes;
            this.str_valor = valor;
            this.int_tipo = tipo;
            this.int_estado = estado;
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            if (str_Codigo == "" || str_nombres == "" || str_ingredientes == "" ||
                str_valor == ""  )
            {
                str_msn = "Debe ingreasar toda la informacion requerida";
            }
            else {
                cls_Funciones objActualizar = new cls_Funciones();
                objActualizar.fnt_Actualizar
                    (str_Codigo, str_nombres, str_ingredientes, str_valor, int_tipo,
                    int_estado);
                str_msn = "El PLATO " + str_nombres  +  " HA SIDO ACTUALIZADO";
            }
        }
        public string getMsn() { return str_msn; }
    }
}
