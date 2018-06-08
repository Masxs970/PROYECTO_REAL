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
        public SqlConnection cn = new SqlConnection("Data Source=DESKTOP-I3GP44S;Initial Catalog=sistema_tienda;Integrated Security=True");
        public ViewCompras()
        {
            InitializeComponent();
        }

        private void SalirCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //void Buscar()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("sp_facturacion", cn);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    da.SelectCommand.Parameters.Add("@fechastart", SqlDbType.DateTime).Value = desde.Text;
        //    da.SelectCommand.Parameters.Add("@fechaend", SqlDbType.DateTime).Value = hasta.Text;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    this.ComprasGrid.DataSource = dt;

        //}

        private void ComprasButton_Click(object sender, EventArgs e)
        {
            //Leer archivo configuracion
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
            //conectar con la base de datos
            SqlConnection connection = new SqlConnection(setting.ConnectionString);
            //Escribimos la sentencia que necesitamos
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



        private void ViewCompras_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Leer Archivo Configuracion
            //ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];

            ////Conectarme con la bbdd
            //SqlConnection conn = new SqlConnection(setting.ConnectionString); //Elemento 

            ////Seleccionar la tabla 
            //string query1 = "INSERT INTO sistema_tienda.dbo.sp_facturacion" + "([fecha], [nombre], [precio], [descripcion]) VALUES (" + FechaBox.Value + ", '" + ProductoBox.Text + "', " + PrecioBox.Text + ", '" + DescripcionBox.Text + "' )";


            //SqlCommand InsertData = new SqlCommand(query1,  conn);  //Comando SQL 


            //try
            //{
            //    //Abrir la conexion
            //    conn.Open();

            //    InsertData.ExecuteNonQuery();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se ha podido añadir la nueva compra" + ex.Message);
            //}
            //Leer archivo configuracion

            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
            //conectar con la base de datos
            SqlConnection connection = new SqlConnection(setting.ConnectionString);
            string sentencia2 = " SELECT * FROM compras";
            SqlCommand x = new SqlCommand(sentencia2, connection);
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


            try
            {

                SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-I3GP44S;Initial Catalog=sistema_tienda;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("sp_InsertaCompra", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = FechaBox.Text;
                cmd.Parameters.Add("@producto", SqlDbType.VarChar).Value = ProductoBox.Text;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = PrecioBox.Text;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = DescripcionBox.Text;


                Conexion.Open();

                cmd.ExecuteNonQuery();

                Conexion.Close();
                MessageBox.Show("Datos insertados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Datos No Insertados" + ex.Message);
            }
        }

    }

}
    


