using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2.Formularios
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False";
            string consultaSQL = "";

            // Verifica si se ingresó un ID de compra o un DNI de cliente
            if (!string.IsNullOrEmpty(txtIDCompra.Text))
            {
                // Consulta por ID de compra
                consultaSQL = "SELECT * FROM Compras WHERE IDCompra = @IDCompra";
            }
            else if (!string.IsNullOrEmpty(txtIDCompra.Text)) // Cambiado de txtIDCompra.Text a txtDNI.Text
            {
                // Consulta por DNI de cliente
                consultaSQL = "SELECT * FROM Compras WHERE IdCliente = (SELECT IdCliente FROM Clientes WHERE DNI = @DNI)";
            }
            else
            {
                // Si no se ingresó ningún valor, muestra un mensaje al usuario
                MessageBox.Show("Por favor ingrese un ID de compra o un DNI de cliente.");
                return;
            }

            // Ejecuta la consulta
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(consultaSQL, cn);

                // Verifica si se ingresó un ID de compra o un DNI de cliente y establece el parámetro correspondiente
                if (!string.IsNullOrEmpty(txtIDCompra.Text))
                {
                    cmd.Parameters.AddWithValue("@IDCompra", txtIDCompra.Text);
                }
                else if (!string.IsNullOrEmpty(txtIDCompra.Text))
                {
                    cmd.Parameters.AddWithValue("@DNI", txtIDCompra.Text);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Muestra los resultados en el DataGridView
                dgvConsultasCompras.DataSource = dataTable;
            }
        }

        private void txtIDCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Compras", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvConsultasCompras.DataSource = dt;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}