using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace GulfoMusicalStoreGUI
{
    public partial class FrmClientes : Form
    {
        public ClienteService ClienteService;
        public FrmClientes()
        {
            InitializeComponent();
            MapearDtgTodos(DtgClientes);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
             MapearDtgClientesPrimerNombre(DtgClientes, TxtPrimerNombre.Text.ToUpper());
        }

        private void MapearDtgTodos(DataGridView Dtg)
        {
            ClienteService = new ClienteService(ConfigConnection.ConnectionString);
            DtgClientes.Rows.Clear();
            foreach (var item in ClienteService.ConsultarClientes())
            {
                int n = DtgClientes.Rows.Add();
                Dtg.Rows[n].Cells[0].Value = item.Cedula;
                Dtg.Rows[n].Cells[1].Value = item.PrimerNombre;
                Dtg.Rows[n].Cells[2].Value = item.SegundoNombre;
                Dtg.Rows[n].Cells[3].Value = item.PrimerApellido;
                Dtg.Rows[n].Cells[4].Value = item.SegundoApellido;
                Dtg.Rows[n].Cells[5].Value = item.Correo;
                Dtg.Rows[n].Cells[6].Value = item.Telefono;
                Dtg.Rows[n].Cells[7].Value = item.Direccion;
                Dtg.Rows[n].Cells[8].Value = item.Lugar.Ciudad;
                Dtg.Rows[n].Cells[9].Value = item.Barrio.Nombre;
            }
            TxtTotal.Text = ClienteService.ConsultarClientes().Count.ToString();
        }


        private void MapearDtgClientesCedula(DataGridView Dtg,string cedula)
        {
            ClienteService = new ClienteService(ConfigConnection.ConnectionString);
            DtgClientes.Rows.Clear();
            foreach (var item in ClienteService.FiltrarCLientesCedula(cedula))
            {
                int n = DtgClientes.Rows.Add();
                Dtg.Rows[n].Cells[0].Value = item.Cedula;
                Dtg.Rows[n].Cells[1].Value = item.PrimerNombre;
                Dtg.Rows[n].Cells[2].Value = item.SegundoNombre;
                Dtg.Rows[n].Cells[3].Value = item.PrimerApellido;
                Dtg.Rows[n].Cells[4].Value = item.SegundoApellido;
                Dtg.Rows[n].Cells[5].Value = item.Correo;
                Dtg.Rows[n].Cells[6].Value = item.Telefono;
                Dtg.Rows[n].Cells[7].Value = item.Direccion;
                Dtg.Rows[n].Cells[8].Value = item.Lugar.Ciudad;
                Dtg.Rows[n].Cells[9].Value = item.Barrio.Nombre;
            }
            TxtTotal.Text = ClienteService.FiltrarCLientesCedula(cedula).Count.ToString();
        }


        private void MapearDtgClientesPrimerNombre(DataGridView Dtg, string primernombre)
        {
            ClienteService = new ClienteService(ConfigConnection.ConnectionString);
            DtgClientes.Rows.Clear();
            foreach (var item in ClienteService.FiltrarClientesPrimerNombre(primernombre))
            {
                int n = DtgClientes.Rows.Add();
                Dtg.Rows[n].Cells[0].Value = item.Cedula;
                Dtg.Rows[n].Cells[1].Value = item.PrimerNombre;
                Dtg.Rows[n].Cells[2].Value = item.SegundoNombre;
                Dtg.Rows[n].Cells[3].Value = item.PrimerApellido;
                Dtg.Rows[n].Cells[4].Value = item.SegundoApellido;
                Dtg.Rows[n].Cells[5].Value = item.Correo;
                Dtg.Rows[n].Cells[6].Value = item.Telefono;
                Dtg.Rows[n].Cells[7].Value = item.Direccion;
                Dtg.Rows[n].Cells[8].Value = item.Lugar.Ciudad;
                Dtg.Rows[n].Cells[9].Value = item.Barrio.Nombre;
            }
            TxtTotal.Text = ClienteService.FiltrarClientesPrimerNombre(primernombre).Count.ToString();
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            MapearDtgTodos(DtgClientes);
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            MapearDtgClientesCedula(DtgClientes,TxtCedula.Text);
        }
    }
}
