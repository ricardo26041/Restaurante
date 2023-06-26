using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_Funciones_Personal
    {
        private string str_Id;
        private Bitmap bmp;
        private string str_Nombre;
        private string str_Contacto;
        private string str_Correo;

        public void fnt_Consultar1(string Id) 
        {
            String sql = "select Nombre, Contacto, Correo from tbl_personal where PKId = '" + Id + "'";
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
                    str_Correo = reader["Correo"].ToString();
                    Console.WriteLine("Nombre: " + str_Nombre);

                }
                
            }
            obj_conectar.fnt_Desconectar();
        }
        public void fnt_Guardar(string Id, string Nombre, string Contacto, string Correo) 
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "insert into tbl_personal values (@PKId,@Nombre,@Contacto,@Correo)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", Id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contacto", Contacto);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }

        public void fnt_Actualizar(string Id, string Nombre, string Contacto, string Correo)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_personal set Nombre=@Nombre,Contacto=@Contacto,Correo=@Correo  where PKId=@PKId";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKId", Id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contacto", Contacto);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public string getNombre() { return this.str_Nombre; }
        public string getContacto() { return this.str_Contacto; }
        public string getCorreo() { return this.str_Correo; }
    }
}
