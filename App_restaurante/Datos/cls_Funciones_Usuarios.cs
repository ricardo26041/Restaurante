using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_Funciones_Usuarios
    {
        private int int_rol;
        private int int_estado;  
        private DataTable dt;


        public void fnt_consultar(string id)
        {
            String sql = "select FKCodigo_tbl_estado,FKCodigo_tbl_rol from tbl_usuarios where PKUsuario = '" + id + "'";
            cls_conexion obj_conectar = new cls_conexion();
            obj_conectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
                    int_rol = Convert.ToInt16(reader["FKCodigo_tbl_rol"].ToString());
                }
            }
            catch { }
            obj_conectar.fnt_Desconectar();
        }
        public void fnt_guardar(string usuario, string contraseña, string id, int estado, int rol)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "insert into tbl_usuarios values (@PKUsuario,@Contraseña,@PKId_tbl_personal,@FKCodigo_tbl_estado,@FKCodigo_tbl_rol)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKUsuario", usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Parameters.AddWithValue("@PKId_tbl_personal", id);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_rol", rol);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public void fnt_Actualizar(string id, int estado, int rol)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_usuarios set FKCodigo_tbl_estado=@FKCodigo_tbl_estado,FKCodigo_tbl_rol=@FKCodigo_tbl_rol where PKUsuario=@PKUsuario";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKUsuario", id);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_rol", rol);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public int getEstado() { return this.int_estado; }
        public int getRol() { return this.int_rol; }
        public DataTable getDt() { return dt; }

    }
}
