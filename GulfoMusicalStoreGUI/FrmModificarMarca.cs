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
    
    public partial class FrmModificarMarca : Form
    {
        private MarcaService marcaservice;
        public IInventario Inventario { get; set; }
        public FrmModificarMarca()
        {
            InitializeComponent();
            LlenarComboProducto();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           

        }

        private void CmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            Marca marca;
            marca = marcaservice.BuscarCodigoMarca(CmbMarca.Text);
            TxtCodigo.Text = marca.NumeroMarca;
        }

        private void LlenarComboProducto()
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            CmbMarca.Items.Clear();
            foreach (var item in marcaservice.ConsultarMarcas())
            {
                CmbMarca.Items.Add(item.Nombre);
            }
        }

        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos. ");
            }
            else
            {
                marcaservice = new MarcaService(ConfigConnection.ConnectionString);
                Marca marca = marcaservice.BuscarMarca(TxtCodigo.Text);
                marca.Nombre = TxtNombre.Text.Trim().ToUpper();
                MessageBox.Show(marcaservice.ModificarMarca(marca));
                Inventario.Actualizar();
                this.Close();
            }
        }
    }
}
