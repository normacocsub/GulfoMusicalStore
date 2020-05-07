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
        public IVenta Venta { get; set; }
        public Factura Factura { get; set; }
        public IList<Producto> Detalles { get; set; }
        public FrmComprar(Factura factura)
        {
            InitializeComponent();
            LlenarCombo();
            Factura = factura;
            IniciarComboBox();
            

        }

        private void IniciarComboBox()
        {
            productoservice = new ProductoService();
            TxtElectrica.Text = productoservice.ContarFiltradoNombre("Guitarra Electrica").ToString();
            TxtAcustica.Text = productoservice.ContarFiltradoNombre("Guitarra Acustica").ToString();
            TxtPiano.Text = productoservice.ContarFiltradoNombre("Piano").ToString();
            TxtBajo.Text = productoservice.ContarFiltradoNombre("Bajo").ToString();

        }

        

      
        private void LlenarCombo()
        {
            for (int i = 0; i < 200; i++)
            {
                CmbUnidadesAcustica.Items.Add(i.ToString());
                CmbUnidadesElectricas.Items.Add(i.ToString());
                CmbUnidadesPiano.Items.Add(i.ToString());
                CmbUnidadesBajo.Items.Add(i.ToString());
            }
        }
        

        

        private void CalcularUnidadesAcusticas()
        {
            string total = CmbUnidadesAcustica.Text;
            CalcularFactura();
            TxtAcustica.Text = total;
            CmbUnidadesAcustica.Text = "0";
        }

        private void CalcularUnidadesElectricas()
        {
            string total = CmbUnidadesElectricas.Text;
            CalcularFactura();
            TxtElectrica.Text = total;
            CmbUnidadesElectricas.Text = "0";
        }

        private void CalcularUnidadesPiano()
        {
            string total = CmbUnidadesPiano.Text;
            CalcularFactura();
            TxtPiano.Text = total;
            CmbUnidadesPiano.Text = "0";
        }

        private void CalcularUnidadesBajo()
        {
            string total = CmbUnidadesBajo.Text;
            CalcularFactura();
            TxtBajo.Text = total;
            CmbUnidadesBajo.Text = "0";
        }


        private void CalcularFactura()
        {
            CalcularGuitarrasAcusticas();
            CalcularGuitarrasElectricas();
            CalcularPianos();
            CalcularBajos();
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
        private void CalcularGuitarrasAcusticas()
        {
            int numero = VerificarComboBox(CmbUnidadesAcustica.Text);
            CalcularProducto("Guitarra Acustica",numero);
        }
        private void CalcularGuitarrasElectricas()
        {
            int numero = VerificarComboBox(CmbUnidadesElectricas.Text);
            CalcularProducto("Guitarra Electrica", numero);
        }
        private void CalcularPianos()
        {
            int numero = VerificarComboBox(CmbUnidadesPiano.Text);
            CalcularProducto("Piano", numero);
        }
        private void CalcularBajos()
        {
            int numero = VerificarComboBox(CmbUnidadesBajo.Text);
            CalcularProducto("Bajo", numero);
        }


        private void CalcularProducto(string nombreproducto,int numeroproductoscomprar)
        {
            productoservice = new ProductoService();
            int numeroproductosguardados =  productoservice.NumeroProductos(nombreproducto);
            
            if (numeroproductosguardados < numeroproductoscomprar)
            {
                MessageBox.Show($"No se puede comprar este numero de {nombreproducto} ");
            }
            else
            {
                AgregarProductos(numeroproductoscomprar, nombreproducto);
            }
        }



        

        private void AgregarProductos(int numero,string productoname)
        {
            if(productoservice.FiltrarProductos(productoname)== null)
            {
                MessageBox.Show("No hay nada en la lista. ");
            }
            else
            {
                Producto producto = null;
                productoservice = new ProductoService();
                Detalles = new List<Producto>();
                for (int i = 0; i < numero; i++)
                {
                   

                    producto = productoservice.FiltrarProductos(productoname).ElementAt(i);
                    if (Factura.BuscarElemento(producto.Codigo)==null)
                    {
                        Factura.AgregarDetalleFactura(producto);
                    } 
                }
            }
        }

       
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            CalcularUnidadesAcusticas();
            CalcularUnidadesElectricas();
            CalcularUnidadesPiano();
            CalcularUnidadesBajo();
            Venta.TotalVenta(Factura);
            MessageBox.Show("Se han añadido los productos a la factura.");
            this.Close();
        }

       
    }
}
