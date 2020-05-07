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
        public FrmModificarInventario()
        {
            InitializeComponent();
            LlenarComboProducto();
        }


        private void LlenarComboProducto()
        {
            productoservice = new ProductoService();
            CmbInstrumento.Items.Clear();
            foreach (var item in productoservice.ConsultarNombreProductos())
            {
                CmbInstrumento.Items.Add(item.Nombre);
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            productoservice = new ProductoService();
            try
            {
                
                if(CmbInstrumento.Text.Equals("") || TxtPrecio.Text.Equals(""))
                {
                    MessageBox.Show("Complete los campos. ");
                }
                else
                {
                    decimal.Parse(TxtPrecio.Text);
                    Producto producto=productoservice.BuscarProducto(TxtCodigo.Text);
                    producto.Precio = decimal.Parse(TxtPrecio.Text);
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

        private void CmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoservice = new ProductoService();
            Producto producto;
            producto = productoservice.FiltrarCodigo(CmbInstrumento.Text);
            TxtCodigo.Text = producto.Codigo;
        }
    }
}
