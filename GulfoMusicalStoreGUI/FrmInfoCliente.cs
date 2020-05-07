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
    public partial class FrmInfoCliente : Form
    {
        private ClienteService clienteservice;
        public IVenta Venta { get; set; }
        public Factura Factura { get; set; }
        public FrmInfoCliente(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            MapearDatosCliente();
        }

        private void MapearDatosCliente()
        {
            TxtCedula.Text = Factura.Cliente.Cedula;
            TxtPrimerNombre.Text = Factura.Cliente.PrimerNombre;
            TxtSegundoNombre.Text = Factura.Cliente.SegundoNombre;
            TxtPrimerApellido.Text = Factura.Cliente.PrimerApellido;
            TxtSegundoApellido.Text = Factura.Cliente.SegundoApellido;
            CBSexo.Text = Factura.Cliente.Genero;
            TxtCorreo.Text = Factura.Cliente.Correo;
            TxtTelefono.Text = Factura.Cliente.Telefono;
            TxtDireccion.Text = Factura.Cliente.Direccion + " " + Factura.Cliente.Barrio + " " + Factura.Cliente.Ciudad;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Factura.Cliente = null;
            MessageBox.Show("Se ha eliminado al cliente de la factura. ");
            this.Close();
        }

        private void BtnConfirmarDatos_Click(object sender, EventArgs e)
        {
            Venta.TotalVenta(Factura);
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            clienteservice = new ClienteService();
            if(TxtPrimerApellido.Text.Equals("") || TxtPrimerNombre.Text.Equals("") ||  TxtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Por favor Complete los campos. ");
            }
            else
            {
               
                cliente.Direccion = Factura.Cliente.Direccion;
                cliente.Ciudad = Factura.Cliente.Ciudad;
                cliente.Barrio = Factura.Cliente.Barrio;
                cliente = Factura.Cliente;
                cliente.PrimerNombre = TxtPrimerNombre.Text;
                cliente.SegundoNombre = TxtSegundoNombre.Text;
                cliente.PrimerApellido = TxtPrimerApellido.Text;
                cliente.SegundoApellido = TxtSegundoApellido.Text;
                cliente.Correo = TxtCorreo.Text;
                cliente.Genero = CBSexo.Text;
                
                cliente.Telefono = TxtTelefono.Text;
                
       
               

                    MessageBox.Show(clienteservice.ModificarCliente(cliente));
                    Factura.Cliente = null;
                    Factura.AgregarCliente(cliente);
                   
                
               
            }
        }

        

        public void Txtdirection()
        {
            TxtDireccion.Text = CB1.Text + " " + CB2.Text + " " + CB3.Text + " " + CB4.Text + " " + CB5.Text + " " + CB6.Text
                + " " + TxtBarrio.Text + " " + TxtCiudad.Text;
        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CB4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CB5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CB6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CBBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void CBCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void TxtBarrio_TextChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }
    }
}
