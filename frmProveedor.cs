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


namespace CRUD2.Formularios
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        // private void btnAgregar_Click(object sender, EventArgs e)
        // {

        // }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Proveedores (Nombre_proveedor, Contacto, Telefono, CorreoElectronico) VALUES ('" + txtNomProv.Text + "','" + txtContacto.Text + "','" + txtTelefono.Text + "', '" + txtCorElec.Text + "');\r\n", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Agrego Exitosamente a " + txtNomProv.Text + ".");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Proveedores SET Nombre_Proveedor = '" + txtNomProv.Text + "', Contacto = '" + txtContacto.Text + "', Telefono = '" + txtTelefono.Text + "', CorreoElectronico = '" + txtCorElec.Text + "'  WHERE ID = '" + txtID.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Modifico Exitosamente a " + txtNomProv.Text + ".");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Proveedores WHERE ID = '" + txtID.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Elimino Exitosamente a " + txtNomProv.Text + ".");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Proveedores", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvProveedor.DataSource = dt;
            }
        }
    }
}
