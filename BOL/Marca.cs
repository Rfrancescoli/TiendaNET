using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BOL
{
    public class Marca
    {
        DBAcces conexion = new DBAcces();

        public DataTable listar()
        {
            return conexion.listarDatos("spu_marcas_listar");
        }
    }
}
