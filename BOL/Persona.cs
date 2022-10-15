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
    public class Persona
    {
        DbAccess acceso = new DbAccess();
        public DataTable listarPersonaActivas()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_PERSONAS_LISTAR_ACTIVO", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }
        public DataTable listarPersonas()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_PERSONAS_LISTAR", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }

        public void registrarPersona(string nombres, string apellidos, string dni, string fechanacimineto, string direccion, string email, string celular, char sexo)
        {
            SqlCommand comando = new SqlCommand("SPU_PERSONAS_REGISTRAR", acceso.getConexion());
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
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void editarPersona(string nombres, string apellidos, string dni, string fechanacimineto, string direccion, string email, string celular, char sexo, int idpersona)
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

        public void eliminarPersona(int idpersona)
        {
            SqlCommand comando = new SqlCommand("SPU_PERSONA_ELIMINAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idpersona", idpersona);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }
        
        public void activarPersona(int idpersona)
        {
            SqlCommand comando = new SqlCommand("SPU_PERSONA_ACTIVAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idpersona", idpersona);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }
        
        public DataTable buscarPersona(int idpersona)
        {
            DataTable data = new DataTable();
            SqlCommand comando = new SqlCommand("SPU_PERSONA_BUSCAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idpersona", idpersona);
            data.Load(comando.ExecuteReader());
            acceso.cerrarConexion();

            return data;
        }

    }
}
