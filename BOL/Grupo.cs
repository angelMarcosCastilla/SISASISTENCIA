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

        public void editarGrupos(string grado)
        {
            SqlCommand comando = new SqlCommand("SPU_PERSONA_EDITAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@fechanacimineto", fechanacimineto);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@idpersona", idpersona);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }
    }
}
