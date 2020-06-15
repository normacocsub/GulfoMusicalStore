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
    public partial class FrmFacturas : Form
    {
        public FacturaService facturaService;
        public FrmFacturas()
        {
            InitializeComponent();
            MapearDtgFactura(DtgFactura);
            bloquearcmb();
        }

        public void bloquearcmb()
        {
            if (ConfigConnection.Codigo == 1)
            {
                CBBusqueda.Items.Add("Sede Bogota");
                CBBusqueda.Items.Add("Sede Cali");
                CBBusqueda.Items.Add("Sede Barranquilla");
            }
        }

        private void MapearDtgFactura(DataGridView dtg)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.ConsultarFacturas())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.ConsultarFacturas().Count.ToString();
        }

        


        private void MapearDtgFiltroFecha(DataGridView dtg,DateTime fechainicial,DateTime fechafinal)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltrarFacturaFecha(fechainicial,fechafinal))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.FiltrarFacturaFecha(fechainicial, fechafinal).Count.ToString();
        }

       


        private void MapearDtgFiltroEstado(DataGridView dtg, string estado)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltroFacturaEstado(estado))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.FiltroFacturaEstado(estado).Count.ToString();
        }

       


        private void MapearDtgFiltroCedula(DataGridView dtg, string cedula)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltrarFacturasCedula(cedula))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.FiltrarFacturasCedula(cedula).Count.ToString();
        }

       



        private void MapearDtgFiltroNumeroFactura(DataGridView dtg, int numero)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltroNumeroFactura(numero))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;
                
            }
            TxtTotal.Text = facturaService.FiltroNumeroFactura(numero).Count.ToString();
        }


        private void MapearDtgFiltroCiudadFactura(DataGridView dtg, int numero)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltroCiudadFactura(numero))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;

            }
            TxtTotal.Text = facturaService.FiltroCiudadFactura(numero).Count.ToString();
        }

        private void MapearDtgFiltroTotalAsc(DataGridView dtg)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltroTotalAsc())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;

            }
            TxtTotal.Text = facturaService.FiltroTotalAsc().Count.ToString();
        }

        private void MapearDtgFiltroTotalDes(DataGridView dtg)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltroTotalDEs())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Lugar.Ciudad;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
                dtg.Rows[n].Cells[3].Value = item.Iva;
                dtg.Rows[n].Cells[4].Value = item.SubTotal;
                dtg.Rows[n].Cells[5].Value = item.Total;
                dtg.Rows[n].Cells[6].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[7].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[8].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[9].Value = item.Fecha;
                dtg.Rows[n].Cells[10].Value = item.Estado;

            }
            TxtTotal.Text = facturaService.FiltroTotalDEs().Count.ToString();
        }

        private void CBBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBusqueda.Text == "Total Facturas")
            {
                MapearDtgFactura(DtgFactura);
            }

          

            if (CBBusqueda.Text == "Facturas Activas")
            {
                MapearDtgFiltroEstado(DtgFactura, "Activo");
            }
            if (CBBusqueda.Text == "Facturas Inactivas")
            {
                MapearDtgFiltroEstado(DtgFactura, "Inactivo");
            }
            if (CBBusqueda.Text== "Sede Bogota")
            {
                MapearDtgFiltroCiudadFactura(DtgFactura, 1);
            }
            if(CBBusqueda.Text== "Sede Cali")
            {
                MapearDtgFiltroCiudadFactura(DtgFactura, 2);
            }
            if(CBBusqueda.Text== "Sede Barranquilla")
            {
                MapearDtgFiltroCiudadFactura(DtgFactura, 3);
            }
            if(CBBusqueda.Text== "Total Ascendente")
            {
                MapearDtgFiltroTotalAsc(DtgFactura);
            }
            if(CBBusqueda.Text== "Total Descendente")
            {
                MapearDtgFiltroTotalDes(DtgFactura);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(TxtNumeroFactura.Text);
                facturaService = new FacturaService(ConfigConnection.ConnectionString);
                if (facturaService.BuscarFactura(numero) == null)
                {
                    MessageBox.Show("No existe esta factura. ");
                }
                else
                {
                    Factura factura;
                    factura = facturaService.BuscarFactura(numero);
                    FrmFacturaIndividual frmFacturaindi = new FrmFacturaIndividual(factura);
                    frmFacturaindi.Show();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo puede escribir numeros aqui. "+ex.Message.ToString());
            }
        }

        private void TxtNumeroFactura_TextChanged_1(object sender, EventArgs e)
        {
            int numero;
            if (TxtNumeroFactura.Text == "")
            {
                numero = 0;
            }
            else
            {
                numero = int.Parse(TxtNumeroFactura.Text);
            }
            MapearDtgFiltroNumeroFactura(DtgFactura, numero);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (DtpHasta.Value < DtpDesde.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor. ");
            }
            else
            {
                DateTime fechaDesde, fechaHasta, fecha, fecha2;
                fecha = DtpDesde.Value;
                fechaDesde = new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
                fecha2 = DtpHasta.Value;
                fechaHasta = new DateTime(fecha2.Year, fecha2.Month, fecha2.Day, 23, 59, 59);
                MapearDtgFiltroFecha(DtgFactura, fechaDesde, fechaHasta);
            }
        }

        private void TxtCedula_TextChanged_1(object sender, EventArgs e)
        {
            MapearDtgFiltroCedula(DtgFactura, TxtCedula.Text);
        }
    }
}
