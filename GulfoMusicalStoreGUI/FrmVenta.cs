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
    public partial class FrmVenta : Form,IVenta
    {
        public Factura Factura { get; set; }
        public FacturaService facturaservice;
        public FrmVenta()
        {
            InitializeComponent();
            LabelCurso.Enabled = false;
            Labelinstrumento.Enabled = false;
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
               frmClienteDatos = new FrmClienteDatos(Factura);
                frmClienteDatos.Venta = this;
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
                FrmInfoCliente frmInfoCliente = new FrmInfoCliente(Factura);
                frmInfoCliente.Venta = this;
                frmInfoCliente.Show();
            }
           
        }

        
        private void LabelCodigoProducto_Click(object sender, EventArgs e)
        {
            FrmComprar frmcomp = new FrmComprar(Factura);
           
            frmcomp.Venta = this;
            
            frmcomp.Show();
        }

        public void TotalVenta(Factura factura)
        {
            
            Factura = factura;
            Factura.CalcularIVA();
            Factura.CalcularSubTotal();
            Factura.CalcularTotal();
            LabelTotal.Text = Factura.Total.ToString();
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

            }
        }

        private void CBCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBCurso.Text.Equals("No"))
            {
                LabelCurso.Enabled = false;
                Labelinstrumento.Enabled = false;
                Factura.LimpiarListaCurso();
                Factura.CalcularIVA();
                Factura.CalcularSubTotal();
                MapearTablaCurso(DtgCursos);
                LabelTotal.Text = Factura.CalcularTotal().ToString();
            }
            else
            {
                LabelCurso.Enabled = true;
                Labelinstrumento.Enabled = true;
            }
        }

     
        private void LabelCurso_Click_1(object sender, EventArgs e)
        {
            FrmComprarCurso frmCurso = frmCurso = new FrmComprarCurso(Factura);
            frmCurso.Venta = this;
            frmCurso.Show();
        }

     

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(Factura.VerListaProductos().Count==0 && Factura.VerListaCursos().Count == 0)
            {
                MessageBox.Show("No hay Productos para eliminar. ");
            }
            else
            {
                EliminarDetalles frmelm = new EliminarDetalles(Factura);
                frmelm.Venta = this;
                frmelm.Show();
            }
            
        }

        
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            facturaservice = new FacturaService();
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
                    Factura.CalcularCantidad();
                    Factura.Fecha = DateTime.Now;
                    MessageBox.Show(facturaservice.GuardarFactura(Factura));
                }
            }
        }
    }
}
