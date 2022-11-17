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
    public class Usuario
    {
        DbAccess acceso = new DbAccess();
        public DataTable listarUsuariosActivos()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_USUARIO_LISTAR_ACTIVO", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }
        public DataTable listarUsuarios()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_USUARIO_LISTAR", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }

        public void registrarUsuarios(int idpersona, string claveacesso, string nombreusuario)
        {
            SqlCommand comando = new SqlCommand("SPU_USUARIO_REGISTRAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idpersona", idpersona);
            comando.Parameters.AddWithValue("@claveaccesso", claveacesso);
            comando.Parameters.AddWithValue("@nombreusuario", nombreusuario);

            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void editarUsuario(int idusuario, string claveacesso, string nombreusuario)
        {
            SqlCommand comando = new SqlCommand("SPU_USUARIO_EDITAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            comando.Parameters.AddWithValue("@claveaccesso", claveacesso);
            comando.Parameters.AddWithValue("@nombreusuario", nombreusuario);

            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }
        
        public void eliminarUsuario( int idusuario)
        {
            SqlCommand comando = new SqlCommand("SPU_USUARIO_ELIMINAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void activarUsuario(int idusuario)
        {
            SqlCommand comando = new SqlCommand("SPU_USUARIO_ACTIVAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public DataTable buscarUsuarios(int idusuario)
        {
            DataTable data = new DataTable();
            SqlCommand comando = new SqlCommand("SPU_USUARIO_BUSCAR", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            data.Load(comando.ExecuteReader());
            acceso.cerrarConexion();
            return data;
        }
      public DataTable login(string nombreusuario)
      {
         DataTable data = new DataTable();
         SqlCommand comando = new SqlCommand("SPU_USUARIO_LOGIN", acceso.getConexion());
         comando.CommandType = CommandType.StoredProcedure;
         acceso.abrirConexion();
         comando.Parameters.AddWithValue("@nombreusuario", nombreusuario);
         data.Load(comando.ExecuteReader());
         acceso.cerrarConexion();
         return data;
      }

        public void editarUsusarioSinClave(int idusuario, string nombreusuario)
        {
                SqlCommand comando = new SqlCommand("SPU_USUARIO_REGISTRAR_SIN_CLAVE", acceso.getConexion());
                comando.CommandType = CommandType.StoredProcedure;
                acceso.abrirConexion();
                comando.Parameters.AddWithValue("@idusuario", idusuario);
                comando.Parameters.AddWithValue("@nombreusuario", nombreusuario);

                comando.ExecuteNonQuery();
                acceso.cerrarConexion();
        }

   }
}
