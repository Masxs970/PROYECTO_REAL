using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    public partial class ViewCompras : Form
    {
        public ViewCompras()
        {
            InitializeComponent();
        }

        private void SalirCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprasButton_Click(object sender, EventArgs e)
        {
            //Leer archivo configuracion
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
            //conectar con la base de datos
            SqlConnection connection = new SqlConnection(setting.ConnectionString);
            //Seleccionar los campos de operación
            string sentencia = "exec sp_facturacion";
            SqlCommand x = new SqlCommand(sentencia, connection);
            //Mostrarlos en la grid
            try
            {
                //Abrir la conexión
                connection.Open();
                //Ejecutar comando
                SqlDataReader rdr = x.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                this.ComprasGrid.DataSource = dt;
                //Cierro el Datareader, cerrara tb la conexión
                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error" + ex.Message);
            }

        }
    }
}

