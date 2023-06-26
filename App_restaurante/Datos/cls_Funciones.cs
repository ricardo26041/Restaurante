using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;

namespace Datos
{
    public class cls_Funciones
    {
        private DataTable dt; // para llenar combo. revisar en clase
        private Bitmap bmp;
        private string str_Codigo;
        private string str_nombres;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private byte[] by_imagen;

        //funcion Consultar 
        public void fnt_consultar(string cod)
        {
            String sql = "select Nombre, Ingredientes, valor, FKCodigo_tbl_tipo, FKCodigo_tbl_estado,Foto from tbl_platos where PKCOdigo = '" + cod + "'";
            cls_conexion obj_conectar = new cls_conexion();
            obj_conectar.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, obj_conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["Foto"]);
                    bmp = new Bitmap(ms);
                    str_nombres = reader["Nombre"].ToString();
                    str_ingredientes = reader["Ingredientes"].ToString();
                    str_valor = reader["valor"].ToString();
                    int_tipo = Convert.ToInt16(reader["FKCodigo_tbl_tipo"].ToString());
                    int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
                    Console.WriteLine("Nombre: " + str_nombres);
                }
            }
            catch { }
            obj_conectar.fnt_Desconectar();
        }
        // Funcion Actualizar 

        public void fnt_Actualizar(string cod, string nombre, string ingredientes, string valor,
            int tipo, int estado  )
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "update tbl_platos set Nombre=@Nombre,Ingredientes=@Ingredientes,valor=@valor, " +
            "FKCodigo_tbl_tipo=@FKCodigo_tbl_tipo,FKCodigo_tbl_estado=@FKCodigo_tbl_estado where PKCOdigo=@PKCOdigo";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCOdigo", cod);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Ingredientes",ingredientes);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_Estado", estado);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();

        }
        //Funcion Guardar *****************************************************************************************
        public void fnt_guardarP(string Cod, string Nom, string ingr, string valor, int tipo, int estado, byte[] Foto)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_conectar();
            string comando = "insert into tbl_platos values (@PKCOdigo,@Nombre,@Ingredientes,@Valor,@FK_Codigo_tbl_tipo,@FKCodigo_tbl_estado,@Foto)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCOdigo",Cod);
            cmd.Parameters.AddWithValue("@Nombre", Nom);
            cmd.Parameters.AddWithValue("@Ingredientes", ingr);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@FK_Codigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.Parameters.AddWithValue("@Foto", Foto);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();

        }

        public Bitmap getBmp() { return bmp; }
        public string getNombres() { return this.str_nombres; }
        public string getIngredientes() { return this.str_ingredientes; }
        public string getValor() { return this.str_valor; }
        public int    getTipo() { return this.int_tipo; }
        public int    getEstado() { return this.int_estado; }
        
    }
}
