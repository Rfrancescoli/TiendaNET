using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;

namespace BOL
{
    public class Categoria
    {
        DBAcces conexion = new DBAcces();

        public DataTable listar()
        {
            return conexion.listarDatos("spu_categorias_listar");
        }
    }
}
