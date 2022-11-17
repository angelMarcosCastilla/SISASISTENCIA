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

        public void registrarGrupos(int grado, string seccion, char turno)
        {
            SqlCommand comando = new SqlCommand("SPU_REGISTRAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@grado", grado);
            comando.Parameters.AddWithValue("@seccion", seccion);
            comando.Parameters.AddWithValue("@turno", turno);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void editarGrupos(int grado, string seccion, char turno, int idgrupo)
        {
            SqlCommand comando = new SqlCommand("SPU_EDITAR_GRUPOS", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@grado", grado);
            comando.Parameters.AddWithValue("@seccion", seccion);
            comando.Parameters.AddWithValue("@turno", turno);
            comando.Parameters.AddWithValue("@idgrupo", idgrupo);
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

        public DataTable ListarGruposActivos()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_LISTAR_GRUPOS_ACTIVOS", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }


    }
}
