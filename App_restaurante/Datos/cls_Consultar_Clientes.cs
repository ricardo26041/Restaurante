using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class cls_Consultar_Clientes
    {
        private string str_nombre;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;

        public void fnt_ConsultarCliente(string id) 
        {
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_conectar();
            string SQLbuscar;
            SQLbuscar = "select Nombre as 'Cliente',Contacto as 'Contacto',Direccion as 'Direccion' from tbl_clientes where PKId = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if (lectura.Read() == true)
            {
                str_nombre = lectura["Cliente"].ToString();
                str_contacto = lectura["Contacto"].ToString();
                str_direccion = lectura["Direccion"].ToString();
                this.str_msn = "";
            }
            else 
            {
                this.str_msn = "ESTE CLIENTE NO SE ENCUENTRA REGISTRADO";
            }
            obj_Conectar.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }
        public string getMsn() { return this.str_msn; }
    }
}
