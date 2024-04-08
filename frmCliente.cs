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
using System.Net;


namespace CRUD2.Formularios
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                //SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (dni, Nombre, Apellido, Telefono, FechaNacimiento, CorreoElectronico) VALUES ('OMJT920719', 'Omar Eduardo', 'Jaramillo Tinoco', '6441177054', '1992-07-19', 'omarjaramillo71@gmail.com');\r\n", cn);
                SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (dni, Nombre, Apellido, Telefono, FechaNacimiento, CorreoElectronico) VALUES ('" + txtDni.Text +"', '"  + txtNombre.Text + "','"+ txtApellido.Text + "', '" + txtTelefono.Text +"', '" + txtFecNac.Text +"', '" + txtCorElec.Text +"');\r\n", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Agrego Exitosamente a " + txtNombre.Text + ".");
            }
        }

        private void txtCorElec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Clientes SET Nombre = '" + txtNombre.Text + "', Apellido = '" + txtApellido.Text + "', Telefono = '" + txtTelefono.Text + "', FechaNacimiento = '" + txtFecNac.Text + "', CorreoElectronico = '" + txtCorElec.Text + "'  WHERE dni = '" + txtDni.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Modifico Exitosamente a " + txtNombre.Text + ".");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE dni = '" + txtDni.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Elimino Exitosamente a " + txtNombre.Text + ".");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MUP0U1H\\SQLEXPRESS;Initial Catalog=ZapateriaDB;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Clientes", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvCliente.DataSource = dt;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
