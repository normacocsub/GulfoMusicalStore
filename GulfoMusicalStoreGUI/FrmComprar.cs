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
            
            Venta.TotalVenta(Factura);
            MessageBox.Show("Se han añadido los productos a la factura.");
            this.Close();
        }

       
    }
}
