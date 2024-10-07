using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    internal class Conexion
    {

        // Declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        // Constructor privado para asignar valores a las variables de la conexión
        private Conexion()
        {
            this.baseDatos = "Proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        // Proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // Instanciamos una conexión
            MySqlConnection cadena = new MySqlConnection();

            // El bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }

            return cadena;
        }

        // Para evaluar la instancia de la conectividad
        public static Conexion GetInstancia()
        {
            if (con == null) // Quiere decir que la conexión está cerrada
            {
                con = new Conexion(); // Se crea una nueva
            }

            return con;
        }

    }
}
