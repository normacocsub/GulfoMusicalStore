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
        }
    }
}
