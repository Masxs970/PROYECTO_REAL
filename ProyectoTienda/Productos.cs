using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoTienda
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        
        private void SalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientesProductos_Click(object sender, EventArgs e)
        {
            ViewClientes j = new ViewClientes();
            j.Show();
        }

        private void ViewProductos_Click(object sender, EventArgs e)
        {
            //Leer archivo configuracion
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
            //conectar con la base de datos
            SqlConnection connection = new SqlConnection(setting.ConnectionString);
            //Seleccionar los campos de operación
            string sentencia = "exec sp_articulo";
            SqlCommand x  = new SqlCommand(sentencia, connection);
            //Mostrarlos en la grid
            try
            {
                //Abrir la conexión
                connection.Open();
                //Ejecutar comando
                SqlDataReader rdr = x.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                this.ProductosGrid.DataSource = dt;
                //Cierro el Datareader, cerrara tb la conexión
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar" + ex.Message);
            }



        }
    }
}
