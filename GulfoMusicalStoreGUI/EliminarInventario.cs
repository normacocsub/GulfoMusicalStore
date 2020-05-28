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
    public partial class EliminarInventario : Form
    {
        private ProductoService productoservice;
        public IInventario Inventario { get; set; }
        public EliminarInventario()
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CmbInstrumento.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos. ");
            }
            else
            {
                Producto producto = productoservice.BuscarProducto(TxtCodigo.Text);
                MessageBox.Show(productoservice.EliminarProducto(producto));
                Inventario.Actualizar();
                this.Close();
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
