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
    public partial class FrmInventario : Form, iInventario , iUnlockInventario
    {
        private MarcaService marcaservice;
        private ProductoService productoservice;
        public FrmInventario()
        {
            InitializeComponent();
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            MapearProductos(DtgProductos);
            MapearMarcas(DtgMarcas);
            LlenarComboMarca();
            labelsede.Text = ConfigConnection.CiudadConectada;
            DesactivarTxtSede();
        }

       
       public void DesactivarTxtSede()
        {
            if(ConfigConnection.Codigo==2 || ConfigConnection.Codigo == 3)
            {
                BtnModificarMarca.Enabled = false;
                BtnRegistrarProducto.Enabled = false;
                BtnRegistrarMarca.Enabled = false;
                BtnModificarProducto.Enabled = false;
            }
        }

       
        private void BtnRegistrarMarca_Click(object sender, EventArgs e)
        {
            BtnRegistrarMarca.Enabled = false;
            FrmRegistrarMarca frmcrearmarca = new FrmRegistrarMarca();
            frmcrearmarca.UnlockInventario = this;
            frmcrearmarca.Inventario = this;
            frmcrearmarca.Show();
        }

        private void MapearProductos(DataGridView dtg)
        {
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            dtg.Rows.Clear();
            foreach (var item in productoservice.ConsultarProductos())
            {
                int n = dtg.Rows.Add();
                
                dtg.Rows[n].Cells[0].Value = item.Codigo;
                dtg.Rows[n].Cells[1].Value = item.Nombre;
                dtg.Rows[n].Cells[2].Value = item.Precio;
                dtg.Rows[n].Cells[3].Value = item.Marca.Nombre;
            }
            TxtTotal.Text = productoservice.ConsultarProductos().Count.ToString();
        }

       
        private void MapearMarcas(DataGridView dtg)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            dtg.Rows.Clear();
            foreach (var item in marcaservice.ConsultarMarcas())
            {
                int n = dtg.Rows.Add();

                dtg.Rows[n].Cells[0].Value = item.NumeroMarca;
                dtg.Rows[n].Cells[1].Value = item.Nombre;
            }
            TxtTotalMarcas.Text = marcaservice.ConsultarMarcas().Count().ToString();
        }

        
      

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnModificarProducto.Enabled = false;
            FrmModificarInventario frmmodi = new FrmModificarInventario();
            frmmodi.IInventario = this;
            frmmodi.UnlockInventario = this;
            frmmodi.Show();
        }

       
       

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            BtnRegistrarProducto.Enabled = false;
            FrmRegistrarProducto frmprod = new FrmRegistrarProducto();
            frmprod.Inventario = this;
            frmprod.UnlockInventario = this;
            frmprod.Show();
        }

        public void Actualizar()
        {
            MapearProductos(DtgProductos);
            MapearMarcas(DtgMarcas);
        }

        

        private void BtnModificarMarca_Click(object sender, EventArgs e)
        {
            BtnModificarMarca.Enabled = false;
            FrmModificarMarca FrmModificar = new FrmModificarMarca();
            FrmModificar.Inventario = this;
            FrmModificar.UnlockInventario = this;
            FrmModificar.Show();
        }

        private void CmbFiltradoMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            Marca marca;
            marca = marcaservice.FiltrarMarca(CmbFiltradoMarca.Text);
            DtgProductos.Rows.Clear();
            foreach (var item in productoservice.FiltrarProductosMarca(marca.NumeroMarca))
            {
                int n = DtgProductos.Rows.Add();

                DtgProductos.Rows[n].Cells[0].Value = item.Codigo;
                DtgProductos.Rows[n].Cells[1].Value = item.Nombre;
                DtgProductos.Rows[n].Cells[2].Value = item.Precio;
                DtgProductos.Rows[n].Cells[3].Value = item.Marca.Nombre;
            }
            TxtTotal.Text = productoservice.FiltrarProductosMarca(marca.NumeroMarca).Count.ToString();
        }

        private void LlenarComboMarca()
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            CmbFiltradoMarca.Items.Clear();
            foreach (var item in marcaservice.ConsultarMarcas())
            {
                CmbFiltradoMarca.Items.Add(item.Nombre);
            }
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            MapearProductos(DtgProductos);
        }

        public void unlockInventario()
        {
            BtnRegistrarProducto.Enabled = true;
            BtnRegistrarMarca.Enabled = true;
            BtnModificarProducto.Enabled = true;
            BtnModificarMarca.Enabled = true;
        }
    }
}
