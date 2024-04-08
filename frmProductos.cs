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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Nombre_Producto, Descripcion, Precio, Stock) VALUES ('" + txtNomProd.Text + "','" + txtDescripcion.Text + "','" + txtPrecio.Text + "', '" + txtStock.Text + "');\r\n", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Agrego Exitosamente a " + txtNomProd.Text + ".");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Nombre_Producto = '" + txtNomProd.Text + "', Descripcion = '" + txtDescripcion.Text + "', Precio = '" + txtPrecio.Text + "', Stock = '" + txtStock.Text + "'  WHERE SKU = '" + txtSKU.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Modifico Exitosamente a " + txtNomProd.Text + ".");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Productos", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvProductos.DataSource = dt;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE SKU = '" + txtSKU.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Elimino Exitosamente a " + txtNomProd.Text + ".");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
