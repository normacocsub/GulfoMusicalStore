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
        MarcaService marcaservice;
        public IInventario Inventario { get; set; }
        public FrmRegistrarMarca()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            if (TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo. ");
            }
            else
            {
                Marca marca = new Marca();
                marca.Nombre = TxtNombre.Text.Trim().ToUpper();
                MessageBox.Show(marcaservice.GuardarMarca(marca));
                Inventario.Actualizar();
                this.Close();
            }
        }
    }
}
