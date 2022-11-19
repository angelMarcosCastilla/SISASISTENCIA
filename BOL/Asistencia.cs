using System;
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
      public DataTable registrarAsistenciaGeneral(int idpersona)
      {

         DataTable data = new DataTable();
         SqlCommand comando = new SqlCommand("SPU_ASISTENCIA_MATRICULADOS", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@idpersona", idpersona);
         data.Load(comando.ExecuteReader());
         acceso.cerrarConexion();
         return data;
        }
        public DataTable buscarUltimaAsistencia(int idmatricula)
        {

            DataTable data = new DataTable();
            SqlCommand comando = new SqlCommand("SPU_FECHAINGRESO", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idmatricula", idmatricula);
            data.Load(comando.ExecuteReader());
            acceso.cerrarConexion();
            return data;
        }

        public void registrarAsistenciaSalida(int idusuarioautoriza, string fechahorapermiso, int idmotivo, string descripcion, int idmatricula, int idasistencia)
      {
         SqlCommand comando = new SqlCommand("SPU_ASISTENCIA_REGISTRAR_SALIDA", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         
         comando.Parameters.AddWithValue("@idusuarioautoriza", idusuarioautoriza);
         comando.Parameters.AddWithValue("@fechahorapermiso", fechahorapermiso);
         comando.Parameters.AddWithValue("@idmotivo", idmotivo);
         comando.Parameters.AddWithValue("@descripcion", descripcion);
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.Parameters.AddWithValue("@idasistencia", idasistencia);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }
   }
}
