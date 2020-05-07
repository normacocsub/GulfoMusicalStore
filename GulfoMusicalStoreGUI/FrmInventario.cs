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
    public partial class FrmInventario : Form,IInventario
    {
        private MarcaService marcaservice;
        private ProductoService productoservice;
        public FrmInventario()
        {
            InitializeComponent();
            MapearProductos(DtgInventario);
            TotalProductosFiltrado();
            LlenarComboProducto();
        }

        private void TotalProductosFiltrado()
        {
            LabelNGAcustica.Text = productoservice.ContarFiltradoNombre("Guitarra Acustica").ToString();
            LabelNGElectrica.Text = productoservice.ContarFiltradoNombre("Guitarra Electrica").ToString();
            LabelNPiano.Text = productoservice.ContarFiltradoNombre("Piano").ToString();
            LabelNBajo.Text = productoservice.ContarFiltradoNombre("Bajo").ToString();
            LabelTotalInstrumentos2.Text = productoservice.TotalProductosDisponible().ToString();
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
        private void BtnRegistrarMarca_Click(object sender, EventArgs e)
        {
            CrearMarca frmcrearmarca = new CrearMarca();
            frmcrearmarca.Show();
        }

        private void MapearProductos(DataGridView dtg)
        {
            productoservice = new ProductoService();
            dtg.Rows.Clear();
            foreach (var item in productoservice.ConsultarProductos())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Nombre;
                dtg.Rows[n].Cells[1].Value = item.Codigo;
                dtg.Rows[n].Cells[2].Value = item.Marca.Nombre;
                dtg.Rows[n].Cells[3].Value = item.Precio;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            marcaservice = new MarcaService();
            productoservice = new ProductoService();
            if(CmbInstrumento.Text.Equals("") || TxtCodigo.Text.Equals("")
               || TxtUnidades.Text.Equals("") )
            {
                MessageBox.Show("Complete los campos por favor. ");
            }
            else
            {
                try
                {
                    int unidades = int.Parse(TxtUnidades.Text);

                    Producto producto = productoservice.BuscarProducto(TxtCodigo.Text);

                    try
                    {
                        for (int i = 0; i < unidades; i++)
                        {
                            productoservice.GuardarProductosInventario(producto);
                        }
                        MessageBox.Show("Se han guardado correctamente. ");
                        MapearProductos(DtgInventario);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error no se pudieron guardar todos los productos. ");
                    }
                    
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                TotalProductosFiltrado();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MapearProductos(DtgInventario);
            TotalProductosFiltrado();
        }

        private void BtnVaciar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = "";
            CmbInstrumento.Text = "";
            TxtUnidades.Text = "";

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarInventario frmmodi = new FrmModificarInventario();
            frmmodi.IInventario = this;
            frmmodi.Show();
        }

        public void Actualizar()
        {
            MapearProductos(DtgInventario);
            TotalProductosFiltrado();
            LlenarComboProducto();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarInventario frmeliminar = new EliminarInventario();
            frmeliminar.Inventario = this;
            frmeliminar.Show();
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto frmprod = new FrmRegistrarProducto();
            frmprod.Inventario = this;
            frmprod.Show();
        }

        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

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
