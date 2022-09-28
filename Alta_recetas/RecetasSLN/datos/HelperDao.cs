using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string cadenaConexion;
        SqlConnection conexion;
        SqlCommand comando;

        private HelperDao()
        {
            cadenaConexion = Properties.Resources.cnn;
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        public static HelperDao obtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public DataTable consultaSQL(string ProcedimientoAlmacenado)
        {
            DataTable table = new DataTable();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = ProcedimientoAlmacenado;

                table.Load(comando.ExecuteReader());


            }catch(Exception e)
            {
                string exp = e.Message;

            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return table;
        }

    }
}
