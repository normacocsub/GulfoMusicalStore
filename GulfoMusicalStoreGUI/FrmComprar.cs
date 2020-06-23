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
    public partial class FrmComprar : Form
    {
        ProductoService productoservice;
        public iUnlockVenta UnlockVenta { get; set; }
        public IVenta Venta { get; set; }
        public Factura Factura { get; set; }
        public IList<Producto> Detalles { get; set; }
        public static IList<Producto> Productos { get; set; }
        public FrmComprar(Factura factura)
        {
            InitializeComponent();
            LlenarCombo();
            Factura = factura;
        }

      
        private void LlenarCombo()
        {
            productoservice = new ProductoService(ConfigConnection.ConnectionString);
            Productos = productoservice.ConsultarProductos();
            foreach (var item in Productos)
            {
                CmbInstrumento.Items.Add(item.Nombre);
            }
        }
        
      
        private int VerificarComboBox(string numerocombo)
        {
            int numero;
            try
            {
               return  numero = int.Parse(numerocombo);
            }
            catch (Exception e)
            {
               return  numero = 0;
            }

        }
       

        private void AgregarProductos(string numero,string productoname)
        {
            int unidades;
            if ((unidades = VerificarComboBox(numero)) == 0)
            {
                MessageBox.Show("Verifique que sea un numero");
            }
            else
            {
                DetalleFactura detalle = null;
                int opcion = 5;
                foreach (var item in Productos)
                {
                    if (item.Nombre.Equals(productoname))
                    {

                        foreach (var item2 in Factura.VerListaProductos())
                        {
                            if (item2.Producto.Nombre.Equals(CmbInstrumento.Text))
                            {
                                detalle = item2;
                                opcion = 1;
                            }

                        }
                        if (Factura.VerListaProductos().Where(P=>P.Producto.Nombre.Equals(CmbInstrumento.Text)).ToList().Count == 0)
                        {
                            opcion = 0;
                        }
                        if (opcion == 0)
                        {
                            Factura.AgregarDetalleFactura(item, unidades);
                        }
                    }

                    if (opcion == 1 && item.Nombre.Equals(CmbInstrumento.Text))
                    {
                        Factura.DetallesFactura.Remove(detalle);
                        Factura.AgregarDetalleFactura(item, unidades);
                    }

                }
            }
        }

       
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (TxtTotal.Text.Equals("") || CmbInstrumento.Text.Equals(""))
            {
                MessageBox.Show("Seleccione Cuantos productos va a llevar o de Click en la x");
            }
            else
            {
                AgregarProductos(TxtTotal.Text, CmbInstrumento.Text);
                Venta.TotalVenta(Factura);
                MessageBox.Show("Se han añadido los productos a la factura.");
                UnlockVenta.unlockventa();
                this.Close();
            }
            
        }
    }
}
