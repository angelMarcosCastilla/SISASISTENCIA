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
    public class Matricula
    {
      DbAccess acceso = new DbAccess();

      public DataTable listarMatriculasActivas()
      {
         DataTable data = new DataTable();
         acceso.abrirConexion();
         SqlDataAdapter adapter = new SqlDataAdapter("SPU_MATRICULA_LISTAR_ACTIVO", acceso.getConexion());
         adapter.Fill(data);
         acceso.cerrarConexion();
         return data;
      }
      public DataTable listarMatriculas()
      {
         DataTable data = new DataTable();
         acceso.abrirConexion();
         SqlDataAdapter adapter = new SqlDataAdapter("SPU_MATRICULA_LISTAR", acceso.getConexion());
         adapter.Fill(data);
         acceso.cerrarConexion();
         return data;
      }
      public DataTable buscarMatricula(int idmatricula)
      {
         DataTable data = new DataTable();
         SqlCommand comando = new SqlCommand("SPU_MATRICULA_BUSCAR", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         data.Load(comando.ExecuteReader());
         acceso.cerrarConexion();
         return data;
      }

      public void registrarMatricula(int idpersona, int idgrupo)
      {
         SqlCommand comando = new SqlCommand("SPU_MATRICULA_REGISTRAR", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@idpersona", idpersona);
         comando.Parameters.AddWithValue("@idgrupo", idgrupo);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }

      public void editarMatricula(int idpersona, int idgrupo, string fechamatricula, int idmatricula)
      {
         SqlCommand comando = new SqlCommand("SPU_MATRICULA_EDITAR", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         comando.Parameters.AddWithValue("@idpersona", idpersona);
         comando.Parameters.AddWithValue("@idgrupo", idgrupo);
         comando.Parameters.AddWithValue("@fechamatricula", fechamatricula);
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }

      public void eliminarMatricula(int idmatricula)
      {
         SqlCommand comando = new SqlCommand("SPU_MATRICULA_ELIMINAR", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }

      public void activarMatricula(int idmatricula)
      {
         SqlCommand comando = new SqlCommand("SPU_MATRICULA_ACTIVAR", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         comando.Parameters.AddWithValue("@idmatricula", idmatricula);
         comando.ExecuteNonQuery();
         acceso.cerrarConexion();
      }
   }
}
