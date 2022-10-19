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
    public class Grupo
    {
        DbAccess acceso = new DbAccess();
        public DataTable ListarGrupos()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_LISTAR_GRUPOS", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }

        public void registrarGrupos(string grado, string seccion, string turno)
        {
            SqlCommand comando = new SqlCommand("SPU_PERSONAS_REGISTRAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@grado", grado);
            comando.Parameters.AddWithValue("@seccion", seccion);
            comando.Parameters.AddWithValue("@turno", turno);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void editarGrupos(string grado, string seccion, string turno)
        {
            SqlCommand comando = new SqlCommand("SPU_EDITAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@grado", grado);
            comando.Parameters.AddWithValue("@seccion", seccion);
            comando.Parameters.AddWithValue("@turno", turno);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void eliminarGrupo(int idgrupo)
        {
            SqlCommand comando = new SqlCommand("SPU_ELIMINAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idgrupo", idgrupo);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void activarGrupo(int idgrupo)
        {
            SqlCommand comando = new SqlCommand("SPU_ACTIVAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idgrupo", idgrupo);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public DataTable buscarGrupo(int idgrupo)
        {
            DataTable data = new DataTable();
            SqlCommand comando = new SqlCommand("SPU_BUSCAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idgrupo", idgrupo);
            data.Load(comando.ExecuteReader());
            acceso.cerrarConexion();

            return data;
        }


    }
}
