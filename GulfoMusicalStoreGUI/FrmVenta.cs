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
    public partial class FrmVenta : Form, IVenta, iUnlockVenta
    {
        public Factura Factura { get; set; }
        public FacturaService facturaservice;
        public FrmVenta()
        {
            InitializeComponent();
            LabelCurso.Enabled = false;
            Factura = new Factura();
            
        }


        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            //Has tu magia y colocas la direccion completa acá para que se vea chido.
            //mira este video mas omenos algo así https://www.youtube.com/watch?v=chJgrml1znc
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmClienteDatos frmClienteDatos;
            if (Factura.Cliente == null)
            {
                BtnRegistrarCliente.Enabled = false;
                frmClienteDatos = new FrmClienteDatos(Factura);
                frmClienteDatos.Venta = this;
                frmClienteDatos.UnlockVenta = this;
                frmClienteDatos.Show();
            }
            else
            {
                MessageBox.Show("El cliente ya esta registrado a esta factura Por Favor Consulte la descripcion del cliente. ");
            }
        }

        private void BtnClienteActual_Click(object sender, EventArgs e)
        {
            if (Factura.Cliente == null)
            {
                MessageBox.Show("No puede ingresar porque no hay un cliente registrado en esta factura. ");
            }
            else
            {

                BtnClienteActual.Enabled = false;
                FrmInfoCliente frmInfoCliente = new FrmInfoCliente(Factura);
                frmInfoCliente.Venta = this;
                frmInfoCliente.UnlockVenta = this;
                frmInfoCliente.Show();
            }
           
        }

        
        private void LabelCodigoProducto_Click(object sender, EventArgs e)
        {

            LabelCodigoProducto.Enabled = false;
            FrmComprar frmcomp = new FrmComprar(Factura);
            frmcomp.Venta = this;
            frmcomp.UnlockVenta = this;
            frmcomp.Show();
        }

        public void TotalVenta(Factura factura)
        {
            
            Factura = factura;
            Factura.CalcularIVA();
            Factura.CalcularSubTotal();
            Factura.CalcularTotal();
            labelTotal.Text = Factura.Total.ToString();
            LabelSubTotal.Text = Factura.SubTotal.ToString();
            LabelIVA.Text = Factura.Iva.ToString();
            MapearTabla(DtgFactura);
            MapearTablaCurso(DtgCursos);
        }


        private void MapearTabla(DataGridView DtgFactura)
        {
            DtgFactura.Rows.Clear();
            foreach (var item in Factura.VerListaProductos())
            {
                int n = DtgFactura.Rows.Add();
                DtgFactura.Rows[n].Cells[0].Value = item.Producto.Codigo;
                DtgFactura.Rows[n].Cells[1].Value = item.Producto.Nombre;
                DtgFactura.Rows[n].Cells[2].Value = item.Producto.Precio;
                DtgFactura.Rows[n].Cells[3].Value = item.Unidades;
                DtgFactura.Rows[n].Cells[4].Value = item.Producto.Marca.Nombre;
            }
        }

        private void MapearTablaCurso(DataGridView DtgCursos)
        {
            DtgCursos.Rows.Clear();
            foreach (var item in Factura.VerListaCursos())
            {
                int n = DtgCursos.Rows.Add();
                DtgCursos.Rows[n].Cells[0].Value = item.Curso.Codigo;
                DtgCursos.Rows[n].Cells[1].Value = item.Curso.Nombre;
                DtgCursos.Rows[n].Cells[2].Value = item.Curso.Total;
                DtgCursos.Rows[n].Cells[3].Value = item.Unidades;

            }
        }

        private void CBCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBCurso.Text.Equals("No"))
            {
                LabelCurso.Enabled = false;
                LabelCurso.Enabled = false;
                Factura.LimpiarListaCurso();
                Factura.CalcularIVA();
                Factura.CalcularSubTotal();
                MapearTablaCurso(DtgCursos);
                Label15.Text = Factura.CalcularTotal().ToString();
            }
            else
            {
                LabelCurso.Enabled = true;
                LabelCurso.Enabled = true;
            }
        }

     
        private void LabelCurso_Click_1(object sender, EventArgs e)
        {
            LabelCurso.Enabled = false;
            FrmComprarCurso frmCurso = frmCurso = new FrmComprarCurso(Factura);
            frmCurso.Venta = this;
            frmCurso.UnlockVenta = this;
            frmCurso.Show();
        }

        
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            facturaservice = new FacturaService(ConfigConnection.ConnectionString);
            if(Factura.VerListaCursos().Count==0 && Factura.VerListaProductos().Count == 0)
            {
                MessageBox.Show("Por favor Compre algo antes de facturar. ");
            }
            else
            {
                if (Factura.Cliente == null)
                {
                    MessageBox.Show("Por favor Registre al cliente antes de facturar.");
                }
                else
                {
                    Factura.Estado = "Activo";
                    Factura.CalcularFactura();
                    Factura.Fecha = DateTime.Now;
                    Lugar lugar = new Lugar();
                    lugar.Codigo = ConfigConnection.Codigo;
                    lugar.Ciudad = ConfigConnection.CiudadConectada;
                    Factura.AgregarLugar(lugar);
                    MessageBox.Show(facturaservice.GuardarFactura(Factura,ConfigConnection.Direccion));
                    Factura = new Factura();
                    Label15.Text = "0";
                    CBCurso.SelectedIndex = 1;
                    MapearTabla(DtgFactura);
                    MapearTablaCurso(DtgCursos);
                    LabelIVA.Text = "0";
                    LabelSubTotal.Text = "0";
                    labelTotal.Text = "0";
                }
            }
        }

        public void unlockventa()
        {
            BtnRegistrarCliente.Enabled = true;
            BtnClienteActual.Enabled = true;
            LabelCodigoProducto.Enabled = true;
        }

        private void labelSede_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Labelinstrumento_Click(object sender, EventArgs e)
        {

        }
    }
}
