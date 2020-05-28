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
            marcaservice = new MarcaService();
            MapearProductos(DtgProductos);
            MapearMarcas(DtgMarcas);
        }

       
       

       
        private void BtnRegistrarMarca_Click(object sender, EventArgs e)
        {
            CrearMarca frmcrearmarca = new CrearMarca();
            frmcrearmarca.Inventario = this;
            frmcrearmarca.Show();
        }

        private void MapearProductos(DataGridView dtg)
        {
            productoservice = new ProductoService();
            dtg.Rows.Clear();
            foreach (var item in productoservice.ConsultarProductos())
            {
                int n = dtg.Rows.Add();
                
                dtg.Rows[n].Cells[0].Value = item.Codigo;
                dtg.Rows[n].Cells[1].Value = item.Nombre;
                dtg.Rows[n].Cells[2].Value = item.Precio;
                dtg.Rows[n].Cells[3].Value = item.Marca.Nombre;
            }
        }

       
        private void MapearMarcas(DataGridView dtg)
        {
            marcaservice = new MarcaService();
            dtg.Rows.Clear();
            foreach (var item in marcaservice.ConsultarMarcas())
            {
                int n = dtg.Rows.Add();

                dtg.Rows[n].Cells[0].Value = item.NumeroMarca;
                dtg.Rows[n].Cells[1].Value = item.Nombre;
            }
        }

        
      

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarInventario frmmodi = new FrmModificarInventario();
            frmmodi.IInventario = this;
            frmmodi.Show();
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

        public void Actualizar()
        {
            MapearProductos(DtgProductos);
            MapearMarcas(DtgMarcas);
        }

        private void DtgCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
