﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BOL
{
    public class Subcategoria
    {
        DBAcces conexion = new DBAcces();

        public DataTable listar(int idcategoria)
        {
            return conexion.listarDatosVariable("spu_subcategorias_listar", "@idcategoria", idcategoria);
        }
    }
}
