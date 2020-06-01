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
    public partial class FrmEliminarMarca : Form
    {
        MarcaService marcaservice;
        public IInventario Inventario { get; set; }
        public FrmEliminarMarca()
        {
            InitializeComponent();
            LlenarComboProducto();
        }

        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (CmbMarca.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos. ");
            }
            else
            {
                Marca marca = marcaservice.BuscarMarca(TxtCodigo.Text);
                MessageBox.Show(marcaservice.EliminarMarca(marca));
                Inventario.Actualizar();
                this.Close();
            }
        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            Marca marca;
            marca = marcaservice.BuscarCodigoMarca(CmbMarca.Text);
            TxtCodigo.Text = marca.NumeroMarca;
            TxtNombre.Text = marca.Nombre;
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
    }
}
