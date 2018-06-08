using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ProyectoTienda
{
    class Conexion
    {
        public string StringConnection;
        protected string sql;
        protected bool result;
        protected SqlConnection conn;
        protected SqlCommand CommandSql;
        protected string message;

        public Conexion()
        {
            //Leer archivo configuracion
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
            //conectar con la base de datos
            this.StringConnection =setting.ConnectionString;
            this.conn = new SqlConnection(this.StringConnection);
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}
