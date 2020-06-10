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
    public partial class FrmRegistrarMarca : Form
    {
        public iUnlockInventario UnlockInventario { get; set; }
        MarcaService marcaservice;
        public iInventario Inventario { get; set; }
        public FrmRegistrarMarca()
        {
            InitializeComponent();
            labelsede.Text = ConfigConnection.CiudadConectada;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            if (TxtNombre.Text.Equals("") || TxtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo. ");
            }
            else
            {
                Marca marca = new Marca();
                marca.Nombre = TxtNombre.Text.Trim().ToUpper();
                marca.NumeroMarca = TxtCodigo.Text;
                MessageBox.Show(marcaservice.GuardarMarca(marca));
                Inventario.Actualizar();
                UnlockInventario.unlockInventario();
                this.Close();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            UnlockInventario.unlockInventario();
            this.Close();
        }
    }
}
