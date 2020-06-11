using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GulfoMusicalStoreGUI
{
    public partial class FrmFacturaIndividual : Form,IVenta
    {
        public FacturaService FacturaService;
        public Factura Factura { get; set; }
        public FrmFacturaIndividual(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            FacturaService = new FacturaService(ConfigConnection.ConnectionString);
            Factura = FacturaService.ConsultarDetallesFactura(factura);
            Factura = FacturaService.ConsultarDetallesCurso(Factura);
            labelsede.Text = Factura.Lugar.Ciudad;
            MapearCursos(DtgCursos);
            MapearProductos(DtgFactura);
            MapearDatos();
        }


        public void MapearProductos(DataGridView dtg)
        {
            DtgFactura.Rows.Clear();
            foreach (var item in Factura.VerListaProductos())
            {
                int n = DtgFactura.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Producto.Codigo;
                dtg.Rows[n].Cells[1].Value = item.Producto.Nombre;
                dtg.Rows[n].Cells[2].Value = item.Producto.Precio;
                dtg.Rows[n].Cells[3].Value = item.Unidades;
                dtg.Rows[n].Cells[4].Value = item.Producto.Marca.Nombre;
            }
        }

        public void MapearCursos(DataGridView dtg)
        {
            DtgCursos.Rows.Clear();
            foreach (var item in Factura.VerListaCursos())
            {
                int n = DtgCursos.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Curso.Codigo;
                dtg.Rows[n].Cells[1].Value = item.Curso.Nombre;
                dtg.Rows[n].Cells[2].Value = item.Curso.Total;
                dtg.Rows[n].Cells[3].Value = item.Unidades;

            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FacturaService = new FacturaService(ConfigConnection.ConnectionString);
            Factura.Estado = CBCambiarEstado.Text;
            MessageBox.Show(FacturaService.ModificarFactura(Factura));
        }

        private void BtnClienteActual_Click(object sender, EventArgs e)
        {
            FrmInfoCliente frmInfoCliente = new FrmInfoCliente(Factura);
            frmInfoCliente.Venta = this;
            frmInfoCliente.Show();
        }

        private void MapearDatos()
        {
            LabelFechaFactura.Text = Factura.Fecha.ToString();
            LabelCodigoFactura.Text = Factura.Numero;
            LabelCantidad.Text = Factura.Cantidad.ToString();
            LabelIVA.Text = Factura.Iva.ToString();
            LabelSubTotal.Text = Factura.SubTotal.ToString();
            LabelTotal.Text = Factura.Total.ToString();
        }

        public void TotalVenta(Factura factura)
        {
            
        }
    }
}
