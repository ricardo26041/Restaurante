using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public  class cls_facturacion
    {
        private int int_ultima;
        private string str_msn;
        cls_conexion obj_conexion = new cls_conexion();
        public void fnt_Registrar_Enc_pedidos(string id_cliente, int valor )
        {

            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_pedidos(FKId_tbl_cliente,Valor,Fecha,FKCodigo_tbl_estado) values('" + id_cliente +"','" + valor +"',current_date(),2)";
            MySqlCommand Comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = Comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
                consultarUltimopedido();


        }
        public void consultarUltimopedido()
        {
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_conectar();
            string SQLbuscar;
            SQLbuscar = "select max(PKN_pedido) as ultima from tbl_pedidos";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if (lectura.Read() == true)
            {
                this.int_ultima = Convert.ToInt16(lectura["ultima"].ToString());
            }


            obj_Conectar.fnt_Desconectar();
        }
        public void fnt_Det_pedidos(int  pedido, double  valor, int cantidad, int codigo )
        {

            obj_conexion.fnt_conectar();
            String consulta = "insert into tbl_detallespedidos(FKN_pedido_tbl_pedidos,valor,Cantidad,FKCodigo_Producto_tbl_platos)"
            + "values('" + pedido + "','" + valor + "','" + cantidad + "','" +codigo+"')";
            MySqlCommand Comando = new MySqlCommand(consulta, obj_conexion.conex);
            MySqlDataReader lectura = Comando.ExecuteReader();
            obj_conexion.fnt_Desconectar();
            consultarUltimopedido();
        }
        public int getUltimopedido() { return int_ultima; }
    }
}

