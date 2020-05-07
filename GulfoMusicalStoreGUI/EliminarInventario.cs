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
        }

        private void CmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoservice = new ProductoService();
            if(CmbInstrumento.Text.Equals("Guitarra Acustica"))
            {
                TxtTotalUnidades.Text = productoservice.ContarFiltradoNombre("Guitarra Acustica").ToString();
            }
            if(CmbInstrumento.Text.Equals("Guitarra Electrica"))
            {
                TxtTotalUnidades.Text = productoservice.ContarFiltradoNombre("Guitarra Electrica").ToString();
            }
            if (CmbInstrumento.Text.Equals("Piano"))
            {
                TxtTotalUnidades.Text = productoservice.ContarFiltradoNombre("Piano").ToString();
            }
            if (CmbInstrumento.Text.Equals("Bajo"))
            {
                TxtTotalUnidades.Text = productoservice.ContarFiltradoNombre("Bajo").ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(CmbInstrumento.Text.Equals("") || TxtUnidades.Text.Equals(""))
                {
                    MessageBox.Show("Complete los campos. ");
                }
                else
                {
                    string nombre = CmbInstrumento.Text;
                    int unidades = int.Parse(TxtUnidades.Text);

                    int total = productoservice.ContarFiltradoNombre(nombre);
                    if (unidades > total)
                    {
                        MessageBox.Show("No puede eliminar este numero de unidades");
                    }
                    else
                    {
                        IList<Producto> productos = new List<Producto>();
                        try
                        {
                            for (int i = 0; i < unidades; i++)
                            {
                                Producto producto;
                                producto = productoservice.FiltrarProductos(nombre).ElementAt(i);
                                productos.Add(producto);
                            }

                            foreach (var item in productos)
                            {
                                productoservice.EliminarProducto(item);
                            }
                            MessageBox.Show("Se han ELiminado todos los productos. ");
                            Inventario.Actualizar();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error. " + ex.Message.ToString());
                        }
                        
                    }
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
