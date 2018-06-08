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
                ConnectionStringSettings m = ConfigurationManager.ConnectionStrings["ProyectoTienda.Properties.Settings.sistema_tiendaConnectionString"];
                //conectar con la base de datos
                SqlConnection o = new SqlConnection(m.ConnectionString);



                SqlCommand cmd = new SqlCommand("sp_InsertaCompra", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = FechaBox.Text;
                cmd.Parameters.Add("@producto", SqlDbType.VarChar).Value = ProductoBox.Text;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = PrecioBox.Text;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = DescripcionBox.Text;


                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Datos insertados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Datos No Insertados" + ex.Message);
            }
        }

    }

}
    


