using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agreagarplatos
    {
        private string str_Codigo;
        private string str_nombres;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private byte[] by_Foto;
        private string str_msn;

        public cls_agreagarplatos(string str_Codigo, string str_nombres, string str_ingredientes, string str_valor, int int_tipo, int int_estado, byte[] aByte)
        {
            this.str_Codigo = str_Codigo;
            this.str_nombres = str_nombres;
            this.str_ingredientes = str_ingredientes;
            this.str_valor = str_valor;
            this.int_tipo = int_tipo;
            this.int_estado = int_estado;
            this.by_Foto = aByte;

            if (str_Codigo== "" || str_nombres == "" || str_ingredientes == "" || str_valor == "" ) {
                str_msn = "Debe ingresar la informacion solicitada";
            }
            else
            {
                cls_Funciones objGuardar = new cls_Funciones();
                objGuardar.fnt_guardarP(str_Codigo, str_nombres, str_ingredientes, str_valor, int_tipo,
                    int_estado, by_Foto);
                str_msn = " EL PLATO " + str_nombres + " HA SIDO REGISTRADO CON EXITO ";
            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
