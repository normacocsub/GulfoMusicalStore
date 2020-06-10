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
    public partial class FrmRegistrarProducto : Form
    {
        public iUnlockInventario UnlockInventario { get; set; }
        private MarcaService marcaservice;
        private ProductoService productoservice;
        public iInventario Inventario { get; set; }
        public FrmRegistrarProducto()
        {
            InitializeComponent();
            LlenarComboMarca();
        }


        private void LlenarComboMarca()
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            CmbMarca.Items.Clear();
            foreach (var item in marcaservice.ConsultarMarcas())
            {
                CmbMarca.Items.Add(item.Nombre);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            marcaservice = new MarcaService(ConfigConnection.ConnectionString);
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            if (TxtCodigo.Text.Equals("") || TxtInstrumento.Text.Equals("") || TxtPrecio.Text.Equals("")
                || CmbMarca.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos. ");
            }
            else
            {
                try
                {
                    decimal precio = decimal.Parse(TxtPrecio.Text.Trim());
                    Producto producto = new Producto();
                    producto.Codigo = TxtCodigo.Text.Trim().ToUpper();
                    producto.Marca = marcaservice.FiltrarMarca(CmbMarca.Text);
                    producto.Nombre = TxtInstrumento.Text.Trim().ToUpper();
                    producto.Precio = precio;
                    MessageBox.Show(productoservice.GuardarProducto(producto));
                    Inventario.Actualizar();
                    UnlockInventario.unlockInventario();
                    this.Close();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Error " + ex.Message.ToString());
                }
                
            }
        }

        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            UnlockInventario.unlockInventario();
            this.Close();
        }

        
    }
}
