using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;
using System.Data.SqlClient;

using ENTITIES;
namespace BOL
{
    public class Producto
    {
        DBAcces conexion = new DBAcces();
        public DataTable listar()
        {
            return conexion.listarDatos("spu_productos_listar");
        }
        public int registrar(EProducto entidad)
        {
            int totalRegistros = 0;
            conexion.abrirConexion();
            try
            {
                SqlCommand comando = new SqlCommand("spu_productos_registrar", conexion.getConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idmarca", entidad.idmarca);
                comando.Parameters.AddWithValue("@idsubcategoria", entidad.idsubcategoria);
                comando.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                comando.Parameters.AddWithValue("@garantia", entidad.garantia);
                comando.Parameters.AddWithValue("@precio", entidad.precio);
                comando.Parameters.AddWithValue("@stock", entidad.stock);

                totalRegistros = comando.ExecuteNonQuery();
            }
            catch
            {
                totalRegistros = -1;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return totalRegistros;
        }
    }
}
