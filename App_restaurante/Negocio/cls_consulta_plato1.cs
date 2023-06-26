using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consulta_plato1
    {
        private DataTable dt; // para llenar combo. revisar en clase
        private Bitmap bmp;
        private string str_Codigo; // igual esta; son variables innecesarias
        private string str_nombres;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;

        
        public void fnt_consultar(string cod)
        {
            cls_Funciones obj_consultar = new cls_Funciones();
            obj_consultar.fnt_consultar(cod);
            this.bmp = obj_consultar.getBmp();
            this.str_nombres= obj_consultar.getNombres();
            this.str_ingredientes = obj_consultar.getIngredientes();
            this.str_valor = obj_consultar.getValor();
            this.int_tipo= obj_consultar.getTipo();
            this.int_estado = obj_consultar.getEstado();
            
        }
        public Bitmap getBmp() { return bmp; }
        public string getNombre() { return this.str_nombres; }
        public string getValor() { return this.str_valor; }
        public int getTipo() { return this.int_tipo; }
        public int getEstado() { return this.int_estado; }
        public string getIngredientes() { return this.str_ingredientes; }
        
    }
}

