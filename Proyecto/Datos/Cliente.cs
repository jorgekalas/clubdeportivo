using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Proyecto.Datos
{
    internal class Cliente
    {
        // Método para verificar el login del cliente usando un procedimiento almacenado
        public DataTable Log_Cli(string numeroDocumento, string carnet)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion(); // Obtener la conexión

                // Crear el comando para el procedimiento almacenado
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Definir los parámetros del procedimiento almacenado
                comando.Parameters.Add("numeroDocumento", MySqlDbType.VarChar).Value = numeroDocumento;
                comando.Parameters.Add("carnet", MySqlDbType.VarChar).Value = carnet;

                // Ejecutar el procedimiento almacenado
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado); // Cargar el resultado en la tabla

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
