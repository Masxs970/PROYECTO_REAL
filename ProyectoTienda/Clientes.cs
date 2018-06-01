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
    public partial class ViewClientes : Form
    {
        
        public ViewClientes()
        {
            InitializeComponent();
        }

        private void FacturacionClientes_Click(object sender, EventArgs e)
        {
            ViewCompras k = new ViewCompras();
            k.Show();

        }

        private void AtrasClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos z = new Productos();
            z.Show();
        }

        private void SalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarClientes_Click(object sender, EventArgs e)
        {
            /*El boton Mostrar Clientes se actualiza directamente al insertar un nuevo cliente */


            //Esta instruccion lee el archivo de configuracion
            ConnectionStringSettings ajuste = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];

            //Esta sentencia conecta la aplicacion a la BBDD
            SqlConnection stablishconn = new SqlConnection(ajuste.ConnectionString);

            //Ahora con esta sentencia vamos a seleccionar la tabla Productos de la BBDD
            string query = "SELECT id_cliente, nombre, apellido, dni, telefono FROM sistema_tienda.dbo.cliente";
            //Comando SQL que lleve a cabo la accion de la query
            SqlCommand command = new SqlCommand(query, stablishconn);

            //Ahora los vamos a mostrar en el DataGrid
            try
            {
                //Esta sentencia abre la conexion
                stablishconn.Open();

                //Ahora debemos ejecutar el comando SQL
                SqlDataReader toread = command.ExecuteReader();
                DataTable thetable = new DataTable();
                thetable.Load(toread);

                this.ClientesGrid.DataSource = thetable;

                //Ahora cerramos el datareader, cerrando tambien asi la conexion
                toread.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("No se ha podido establecer la conexion" + err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Leer Archivo Configuracion
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];

            //Conectarme con la bbdd
            SqlConnection conn = new SqlConnection(setting.ConnectionString); //Elemento 

            //Seleccionar la tabla 
            string query = "INSERT INTO sistema_tienda.dbo.cliente" + "([nombre], [apellido], [dni], [direccion], [email], [telefono]) VALUES ('" + NombreBox.Text  + "','" + ApellidoBox.Text + "','" + dniBox.Text + "', '" + DireccionBox.Text +"', '" + EmailBox.Text + "',  '" + telBox.Text + "')";

            SqlCommand InsertCliente = new SqlCommand(query, conn);  //Comando SQL 


            try
            {
                //Abrir la conexion
                conn.Open();

                InsertCliente.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido añadir al nuevo cliente" + ex.Message);
            }

        }
    }
}
