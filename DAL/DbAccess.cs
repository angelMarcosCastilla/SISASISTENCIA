﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbAccess
    {
        SqlConnection conexion = new SqlConnection("data source=DESKTOP-2UAEKCQ;database=SIS_IESUP;user id=jesus;password=j14m11;integrated security=false");

        public SqlConnection getConexion()
        {
            return conexion;
        }

        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
