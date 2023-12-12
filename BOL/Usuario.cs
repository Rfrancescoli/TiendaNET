using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;                      //Acceso a conexión
using System.Data;              //Objetos
using System.Data.SqlClient;    //Acceso a MSSQL Server

namespace BOL
{
    public class Usuario
    {
        //Instancia de la clase de conexión
        DBAcces conexion = new DBAcces();

        /// <summary>
        /// Inicia sesión utilizando datos del servidor
        /// </summary>
        /// <param name="email">Identificar o nombre de usuario</param>
        /// <returns>
        /// Objeto DataTable conteniendo toda la fila (varios campos)
        /// </returns>
        public DataTable iniciarSesion(string email)
        {
            //1. Objeto que contendrá el resultado
            DataTable dt = new DataTable();

            //2. Abrir conexión
            conexion.abrirConexion();

            //3. Objeto para enviar consulta
            SqlCommand comando = new SqlCommand("spu_usuarios_login", conexion.getConexion());

            //4. Tipo de comando (procedimiento almacenado)
            comando.CommandType = CommandType.StoredProcedure;

            //5. Pasar la(s) variable(s)
            comando.Parameters.AddWithValue("@email", email);

            //6. Ejecutar y obtener/leer los datos
            dt.Load(comando.ExecuteReader());

            //7. Cerrar
            conexion.cerrarConexion();

            //8. Retornamos el objeto con la info
            return dt;

        }
        public DataTable login(string email)
        {
            return conexion.listarDatosVariable("spu_usuarios_login", "@email", email);
        }
    }
}
