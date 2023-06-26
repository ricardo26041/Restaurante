using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_cargar_estado
    {
        private DataTable dt;
        public void fnt_cargarEstado()
        {

            string sql = "select PKCodigo,Descripcion from tbl_estado";
            cls_conexion objConecta = new cls_conexion();
            objConecta.fnt_conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(dt);


            }
            catch (Exception)
            {
                objConecta.fnt_Desconectar();
            }
        }
        public DataTable getDt() { return dt; }
    }
}
