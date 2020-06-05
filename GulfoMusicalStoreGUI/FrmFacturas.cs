using BLL;
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
            MapearDtgFactura(DtgFacturas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MapearDtgFactura(DataGridView dtg)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.ConsultarFacturas())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Cantidad;
                dtg.Rows[n].Cells[2].Value = item.Iva;
                dtg.Rows[n].Cells[3].Value = item.SubTotal;
                dtg.Rows[n].Cells[4].Value = item.Total;
                dtg.Rows[n].Cells[5].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[6].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[7].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[8].Value = item.Fecha;
                dtg.Rows[n].Cells[9].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.ConsultarFacturas().Count.ToString();
        }

        private void BtnFiltrarFecha_Click(object sender, EventArgs e)
        {
            if (DtpFechaFinal.Value < DtpFechaInicial.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor. ");
            }
            else
            {
                DateTime fechaDesde, fechaHasta, fecha, fecha2;
                fecha = DtpFechaInicial.Value;
                fechaDesde = new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
                fecha2 = DtpFechaFinal.Value;
                fechaHasta = new DateTime(fecha2.Year, fecha2.Month, fecha2.Day, 23, 59, 59);
                MapearDtgFiltroFecha(DtgFacturas, fechaDesde, fechaHasta);
            }
            
        }


        private void MapearDtgFiltroFecha(DataGridView dtg,DateTime fechainicial,DateTime fechafinal)
        {
            dtg.Rows.Clear();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            foreach (var item in facturaService.FiltrarFacturaFecha(fechainicial,fechafinal))
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Numero;
                dtg.Rows[n].Cells[1].Value = item.Cantidad;
                dtg.Rows[n].Cells[2].Value = item.Iva;
                dtg.Rows[n].Cells[3].Value = item.SubTotal;
                dtg.Rows[n].Cells[4].Value = item.Total;
                dtg.Rows[n].Cells[5].Value = item.Cliente.Cedula;
                dtg.Rows[n].Cells[6].Value = item.Cliente.PrimerNombre;
                dtg.Rows[n].Cells[7].Value = item.Cliente.Telefono;
                dtg.Rows[n].Cells[8].Value = item.Fecha;
                dtg.Rows[n].Cells[9].Value = item.Estado;
            }
            TxtTotal.Text = facturaService.FiltrarFacturaFecha(fechainicial, fechafinal).Count.ToString();
        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbFiltro.Text== "Total Facturas")
            {
                MapearDtgFactura(DtgFacturas);
            }
            else
            {

            }
        }
    }
}
