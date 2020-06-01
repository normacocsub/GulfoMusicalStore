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
        public static IList<Producto> Productos { get; set; }
        public EliminarInventario()
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
        }
    }
}
