using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace GulfoMusicalStoreGUI
{
    public partial class FrmModificarInventario : Form
    {
        private ProductoService productoservice;
        public IInventario IInventario { get; set; }
        public static IList<Producto> Productos { get; set; }
        public FrmModificarInventario()
        {
            InitializeComponent();
            LlenarComboProducto();
        }


        private void LlenarComboProducto()
        {
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            CmbInstrumento.Items.Clear();
            Productos = productoservice.ConsultarNombreProductos();
            foreach (var item in Productos)
            {
                CmbInstrumento.Items.Add(item.Nombre);
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            try
            {
                
                if(CmbInstrumento.Text.Equals("") || TxtPrecio.Text.Equals("") || TxtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Complete los campos. ");
                }
                else
                {
                    decimal.Parse(TxtPrecio.Text.Trim());
                    Producto producto=productoservice.BuscarProducto(TxtCodigo.Text);
                    producto.Precio = decimal.Parse(TxtPrecio.Text);
                    producto.Nombre = TxtNombre.Text.Trim().ToUpper();
                    MessageBox.Show(productoservice.ModificarPrecioProductos(producto));
                    IInventario.Actualizar();
                    this.Close();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Error. {ex.Message.ToString()}");
            }
        }

       

        private void CmbInstrumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nombre = CmbInstrumento.Text;
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            Producto producto = null;
            foreach (var item in Productos)
            {
                if (item.Nombre == nombre)
                {
                    producto = item;
                }
            }
            TxtCodigo.Text = producto.Codigo;
            TxtPrecio.Text = producto.Precio.ToString();
            TxtNombre.Text = producto.Nombre;
        }

       
    }
}
