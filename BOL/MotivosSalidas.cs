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
    
    public class MotivosSalidas
    {
        DbAccess acceso = new DbAccess();
        public DataTable ListarMotivosSalida()
        {
            DataTable data = new DataTable();
            acceso.abrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_LISTAR_MOTIVOSSALIDA", acceso.getConexion());
            adapter.Fill(data);
            acceso.cerrarConexion();
            return data;
        }

        public void registrarMotivosSalida(string motivosalida)
        {
            SqlCommand comando = new SqlCommand("SPU_REGISTRAR_MOTIVOSSALIDA", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@motivosalida", motivosalida);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public void editarMotivosSalidas(string motivosalida, int idmotivo)
        {
            SqlCommand comando = new SqlCommand("SPU_EDITAR_MOTIVOSSALIDA", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@motivosalida", motivosalida);
            comando.Parameters.AddWithValue("@idmotivo", idmotivo);
            comando.ExecuteNonQuery();
            acceso.cerrarConexion();
        }

        public DataTable buscarMotivosSalidas(int idmotivo)
        {
            DataTable data = new DataTable();
            SqlCommand comando = new SqlCommand("SPU_BUSCAR_MOTIVOSSALIDA", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            acceso.abrirConexion();
            comando.Parameters.AddWithValue("@idmotivo", idmotivo);
            data.Load(comando.ExecuteReader());
            acceso.cerrarConexion();

            return data;
        }

        //Pruebaaaa
    }
}
