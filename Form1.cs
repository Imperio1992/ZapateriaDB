using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD2.Formularios;

namespace CRUD2
{
    public partial class ZapateriaDB : Form
    {
        private object formProductos;

        public ZapateriaDB()
        {
            InitializeComponent();
        }

        private void mensajeDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "¡Bienvenido a ZapateriaBD!, \r\n" +
                "\r\n" +
                "Gracias por visitar nuestra plataforma. En ZapateriaBD, nos dedicamos a proporcionarte los mejores productos y servicios relacionados con calzado. \r\n" +
                "Estamos comprometidos con la calidad, la comodidad y la satisfacción del cliente. \r\n" +
                "\r\n" +
                "¡Esperamos que disfrutes explorando nuestra tienda y encontrando el calzado perfecto para ti! \r\n" +
                "\r\n" +
                "Atentamente, \r\n" +
                "El equipo de ZapateriaBD"
                , "Mensaje de Bienvenida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void misionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nuestra misión en ZapateriaBD es proporcionar a nuestros clientes la mejor experiencia de compra de calzado. \r\n" +
                "\r\n" +
                "Nos esforzamos por ofrecer una amplia gama de productos de alta calidad, garantizando la satisfacción del cliente en cada paso del proceso. \r\n" +
                "\r\n" +
                "Nos comprometemos a mantenernos actualizados con las últimas tendencias en la industria del calzado y a brindar un servicio excepcional que supere las expectativas de nuestros clientes. \r\n" +
                "\r\n" +
                "En ZapateriaBD, nuestra misión es ser la primera opción cuando se trata de encontrar el calzado perfecto para cada ocasión."
                , "Misión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "En ZapateriaBD, nuestra visión es convertirnos en el referente líder en la industria del calzado, reconocidos por nuestra calidad, variedad y servicio excepcional. \r\n" +
                "\r\n" +
                "Nos esforzamos por ser una marca innovadora que se adapta a las necesidades cambiantes de nuestros clientes, ofreciendo una experiencia de compra única y personalizada. \r\n" +
                "\r\n" +
                "Buscamos expandir nuestra presencia en el mercado nacional e internacional, manteniendo siempre nuestro compromiso con la excelencia y la satisfacción del cliente. \r\n" +
                "\r\n" +
                "En ZapateriaBD, aspiramos a ser más que una tienda de calzado; queremos ser el destino preferido para todos aquellos que buscan estilo, comodidad y calidad."
                , "Visión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "En ZapateriaBD, somos una empresa dedicada a ofrecer una amplia gama de productos y servicios relacionados con el calzado. \r\n" +
                "\r\n" +
                "Nuestra misión es proporcionar a nuestros clientes la mejor experiencia de compra, ofreciendo productos de alta calidad, atención personalizada y un ambiente acogedor. \r\n" +
                "\r\n" +
                "Nos enorgullecemos de nuestro compromiso con la excelencia y la satisfacción del cliente, y trabajamos incansablemente para mantenernos a la vanguardia de la industria del calzado. \r\n" +
                "\r\n" +
                "Con años de experiencia en el mercado, nos esforzamos por ser líderes en innovación, estilo y comodidad. \r\n" +
                "\r\n" +
                "En ZapateriaBD, nos comprometemos a superar las expectativas de nuestros clientes en cada paso del camino."
                , "¿Quiénes Somos?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmCliente
            frmCliente formCliente = new frmCliente();

            // Mostrar el formulario
            formCliente.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmCliente
            frmProveedor formProveedor = new frmProveedor();

            // Mostrar el formulario
            formProveedor.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmProductos
            frmProductos productosForm = new frmProductos();

            // Mostrar el formulario frmProductos
            productosForm.Show();
        }

        private void damaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmDamas
            frmDamas damasForm = new frmDamas();

            // Mostrar el formulario frmDamas
            damasForm.Show();
        }

        private void caballeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmCaballeros
            frmCaballeros caballerosForm = new frmCaballeros();

            // Mostrar el formulario frmCaballeros
            caballerosForm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmCompras
            frmCompras comprasForm = new frmCompras();

            // Mostrar el formulario frmCompras
            comprasForm.Show();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
