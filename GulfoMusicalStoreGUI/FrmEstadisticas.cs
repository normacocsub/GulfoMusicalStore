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

namespace GulfoMusicalStoreGUI
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            //Combinacion de Colores.
            Chart1.Palette = ChartColorPalette.Bright;
            Chart2.Palette = ChartColorPalette.Pastel;
            //titulo.
            Chart1.Titles.Add("Estadisticas dia");
            Chart2.Titles.Add("Estadisticas dia");

            //
            Series s;
            Series s2;
            DateTime fecha = DateTime.Now;
            //ponemos los titulos.
            s = Chart2.Series.Add("Cantidad");
            s2 = Chart1.Series.Add("Ventas");
            int cantidad;
            decimal precio;
            /*
            cantidad = estadisticaService.FiltrarFechaDia(fecha.Day).Sum(D => D.Cantidad);
            precio = estadisticaService.FiltrarFechaDia(fecha.Day).Sum(D => D.Precio);
            foreach (var item in estadisticaService.FiltrarFechaDia(fecha.Day))
            {
                s.Points.Clear();
                s2.Points.Clear();
                s.Points.Add(cantidad);
                s2.Points.Add(double.Parse(precio.ToString()));
                LabelCantidad.Text = s.Label = cantidad.ToString();
                LabelTotal.Text = s2.Label = precio.ToString();
            }
            */
        }

        private void BtnFiltar_Click(object sender, EventArgs e)
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

                //Cambiar Titulos
                Chart1.Titles.Clear();
                Chart2.Titles.Clear();
                Chart1.Titles.Add("Estadisticas mes");
                Chart2.Titles.Add("Estadisticas mes");


                //ponemos los titulos.
                Series s = Chart2.Series.FindByName("Cantidad");
                Series s2 = Chart1.Series.FindByName("Ventas");


                s.Points.Clear();
                s2.Points.Clear();
                //sumamos
                int cantidad;
                decimal precio;
                /*
                cantidad = estadisticaService.FiltrarRangoFechas(fechaDesde, fechaHasta).Sum(D => D.Cantidad);
                precio = estadisticaService.FiltrarRangoFechas(fechaDesde, fechaHasta).Sum(D => D.Precio);
                foreach (var item in estadisticaService.FiltrarRangoFechas(fechaDesde, fechaHasta))
                {

                    s.Points.Clear();
                    s2.Points.Clear();

                    s.Points.Add(cantidad);
                    s2.Points.Add(double.Parse(precio.ToString()));
                    LabelCantidad.Text = s.Label = cantidad.ToString();
                    LabelTotal.Text = s2.Label = precio.ToString();
                }
                */
            }
        }
    }
}
