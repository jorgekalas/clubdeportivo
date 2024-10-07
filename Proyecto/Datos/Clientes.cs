using MySql.Data.MySqlClient;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar los parámetros
                comando.Parameters.Add("IN_Nombre", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("IN_Apellido", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("IN_TipoDocumento", MySqlDbType.VarChar).Value = cliente.TipoDocumento;
                comando.Parameters.Add("IN_NumeroDocumento", MySqlDbType.VarChar).Value = cliente.NumeroDocumento;
                comando.Parameters.Add("IN_Socio", MySqlDbType.Bit).Value = cliente.Socio;
                comando.Parameters.Add("IN_Carnet", MySqlDbType.VarChar).Value = cliente.Carnet;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }
    }
}
