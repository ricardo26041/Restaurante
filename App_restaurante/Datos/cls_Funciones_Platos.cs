using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class cls_Funciones_Platos
    {
        private string str_nombre;
        private string str_ingredientes;
        private int int_ValorU;
        private string str_msn;
        public void fnt_Consultarplatos(string Codigo)
        {
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_conectar();
            string SQLbuscar;
            SQLbuscar = "select Nombre as 'Nombre',Ingredientes as 'Ingre', valor as 'precio'from tbl_platos where PKCodigo = '" + Codigo + "'and FKCodigo_tbl_estado = '1'";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if (lectura.Read( )== true) 
            {
                str_nombre = lectura["Nombre"].ToString();
                str_ingredientes = lectura["Ingre"].ToString();
                int_ValorU = Convert.ToInt32(lectura["precio"].ToString());
                this.str_msn = "";
            }
            else 
            {
                this.str_msn = "PRODUCTO AGOTADO / NO SE ENCUENTRA DISPONIBLE"; 
            }
            obj_Conectar.fnt_Desconectar();

        }
        public string getMensaje() { return this.str_msn; }
        public int getprecio() { return int_ValorU; }
        public string getNombre() { return str_nombre; }
        public string getIngredientes(){ return str_ingredientes; }
    }
}
