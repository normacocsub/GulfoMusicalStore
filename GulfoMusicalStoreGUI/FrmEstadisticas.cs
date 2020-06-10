using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Entity;
using BLL;
using System.Security.Cryptography;

namespace GulfoMusicalStoreGUI
{
    public partial class FrmEstadisticas : Form
    {
        private EstadisticasService estadisticasService;
        public FrmEstadisticas()
        {
            InitializeComponent();
            labelsede.Text = ConfigConnection.CiudadConectada;
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            estadisticasService = new EstadisticasService(ConfigConnection.ConnectionString);
            //Combinacion de Colores.
            Chart1.Palette = ChartColorPalette.Bright;
            Chart2.Palette = ChartColorPalette.Pastel;
            chart3.Palette = ChartColorPalette.Fire;
            //titulo.
            Chart1.Titles.Add("Estadisticas dia");
            Chart2.Titles.Add("Estadisticas dia");
            chart3.Titles.Add("Estadisticas dia");

            //
            Series s;
            Series s2;
            Series s3;
            DateTime fecha = DateTime.Now;
            //ponemos los titulos.
            s = Chart2.Series.Add("Cantidad");
            s2 = Chart1.Series.Add("Ventas");
            s3 = chart3.Series.Add("Facturas");
            int cantidad;
            decimal precio;
            int TotalFacturas;
            
            cantidad = estadisticasService.FiltroEstadisticasDia(fecha.Day,fecha.Month,fecha.Year).Sum(D => D.Cantidad);
            precio = estadisticasService.FiltroEstadisticasDia(fecha.Day, fecha.Month, fecha.Year).Sum(D => D.Total);
            TotalFacturas = estadisticasService.FiltroEstadisticasDia(fecha.Day, fecha.Month, fecha.Year).Count;
            foreach (var item in estadisticasService.FiltroEstadisticasDia(fecha.Day, fecha.Month, fecha.Year))
            {
                s.Points.Clear();
                s2.Points.Clear();
                s3.Points.Clear();
                s.Points.Add(cantidad);
                s2.Points.Add(double.Parse(precio.ToString()));
                s3.Points.Add(TotalFacturas);
                LabelCantidad.Text = s.Label = cantidad.ToString();
                LabelTotal.Text = s2.Label = precio.ToString();
                LabelFacturasTotal.Text = s3.Label = TotalFacturas.ToString();
            }
            
        }

       

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde, fechaHasta, fecha, fecha2;
            fecha = DtpDesde.Value;
            fechaDesde = new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
            fecha2 = DtpHasta.Value;
            fechaHasta = new DateTime(fecha2.Year, fecha2.Month, fecha2.Day, 23, 59, 59);

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha destino no puede ser menor a la principal. ");
            }
            else
            {
                //Combinacion de Colores.
                Chart1.Palette = ChartColorPalette.Bright;
                Chart2.Palette = ChartColorPalette.Pastel;
                chart3.Palette = ChartColorPalette.Fire;

                //Cambiar Titulos
                Chart1.Titles.Clear();
                Chart2.Titles.Clear();
                chart3.Titles.Clear();
                Chart1.Titles.Add("Estadisticas mes");
                Chart2.Titles.Add("Estadisticas mes");
                chart3.Titles.Add("Estadisticas mes");

                //ponemos los titulos.
                Series s = Chart2.Series.FindByName("Cantidad");
                Series s2 = Chart1.Series.FindByName("Ventas");
                Series s3 = chart3.Series.FindByName("Facturas");


                s.Points.Clear();
                s2.Points.Clear();
                s3.Points.Clear();
                //sumamos
                int cantidad;
                decimal precio;
                int TotalFacturas;

                cantidad = estadisticasService.FiltroFechaEstadisticas(fechaDesde, fechaHasta).Sum(D => D.Cantidad);
                precio = estadisticasService.FiltroFechaEstadisticas(fechaDesde, fechaHasta).Sum(D => D.Total);
                TotalFacturas = estadisticasService.FiltroFechaEstadisticas(fechaDesde, fechaHasta).Count;
                foreach (var item in estadisticasService.FiltroFechaEstadisticas(fechaDesde, fechaHasta))
                {

                    s.Points.Clear();
                    s2.Points.Clear();
                    s3.Points.Clear();

                    s.Points.Add(cantidad);
                    s2.Points.Add(double.Parse(precio.ToString()));
                    s3.Points.Add(TotalFacturas);
                    LabelCantidad.Text = s.Label = cantidad.ToString();
                    LabelTotal.Text = s2.Label = precio.ToString();
                    LabelFacturasTotal.Text = s3.Label = TotalFacturas.ToString();
                }

            }
        }
    }
}
