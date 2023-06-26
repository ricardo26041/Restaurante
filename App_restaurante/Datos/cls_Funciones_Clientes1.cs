using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_Funciones_Clientes1
    {
        private string str_Id;
        private Bitmap bmp;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Direccion;
        private byte[] by_imagen;
        private string str_mensaje;

        public void fnt_Consultar1(string Id)
        {
            String sql = "select Nombre, Contacto, Direccion from tbl_Clientes where PKId = '" + Id + "'";
            cls_conexion obj_conectar = new cls_conexion();
            obj_conectar.fnt_conectar();
            
            {
                MySqlCommand comando = new MySqlCommand(sql, obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    str_Nombre = reader["Nombre"].ToString();
                    str_Contacto = reader["Contacto"].ToString();
                    str_Direccion = reader["Direccion"].ToString();
                    Console.WriteLine("Nombre: " + str_Nombre);
                }
            }
           
            obj_conectar.fnt_Desconectar();
        }
        public void fnt_GuardarC(string Id, string Nombre, string Contacto, string Direccion)
        {
            try
            {
                cls_conexion obj_conexion = new cls_conexion();
                obj_conexion.fnt_conectar();
                string comando = "insert into tbl_clientes values (@PKId,@Nombre,@Contacto,@Direccion)";
                MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                cmd.Parameters.AddWithValue("@PKId", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Contacto", Contacto);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.ExecuteNonQuery();
                obj_conexion.fnt_Desconectar();
            }
            catch (Exception) { str_mensaje = "Esta persona ya se encuentra registrada o tienes problemas de conexión"; }
        }


        public void fnt_Actualizar(string Id, string Nombre, string Contacto, string Direccion)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_Clientes set Nombre=@Nombre,Contacto=@Contacto,Direccion=@Direccion  where PKId=@PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", Id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contacto", Contacto);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();

        }

        public string getNombre() { return this.str_Nombre; }
        public string getContacto() { return this.str_Contacto; }
        public string getDireccion() { return this.str_Direccion; }
        public string getMensaje() { return this.str_mensaje; }

    }

}
     


    
    

        


