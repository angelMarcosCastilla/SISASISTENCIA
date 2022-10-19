﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BOL
{
   public class Asistencia
   {
      DbAccess acceso = new DbAccess();
      public DataTable listarMatriculasActivas()
      {
         DataTable data = new DataTable();
         acceso.abrirConexion();
         SqlDataAdapter adapter = new SqlDataAdapter("SPU_ASISTENCIA_LISTAR", acceso.getConexion());
         adapter.Fill(data);
         acceso.cerrarConexion();
         return data;
      }

      public void registrarAsistenciaEntrada(int idmatricula)
      {
         SqlCommand comando = new SqlCommand("SPU_ASISTENCIA_REGISTRAR_ENTRADA", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }

      public void registrarAsistenciaSalida(string fechaHorasalida, int idusuarioautoriza, string fechahorapermiso, int idmotivo, string descripcion, int idmatricula)
      {
         SqlCommand comando = new SqlCommand("SPU_ASISTENCIA_REGISTRAR_SALIDA", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@fechahorasalida", fechaHorasalida);
         comando.Parameters.AddWithValue("@idusuarioautoriza", idusuarioautoriza);
         comando.Parameters.AddWithValue("@fechahorapermiso", fechahorapermiso);
         comando.Parameters.AddWithValue("@idmotivo", idmotivo);
         comando.Parameters.AddWithValue("@descripcion", descripcion);
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }
   }
}
