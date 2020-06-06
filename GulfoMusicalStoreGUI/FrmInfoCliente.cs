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
        private LugarService lugarservice;
        public static IList<Lugar> Lugares { get; set; }
        public static IList<Barrio> Barrios { get; set; }
        public FrmInfoCliente(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            MapearDatosCliente();
            CmbBarrio.Enabled = false;
            LlenarComboLugar();
        }

        private void MapearDatosCliente()
        {
            TxtCedula.Text = Factura.Cliente.Cedula;
            TxtPrimerNombre.Text = Factura.Cliente.PrimerNombre;
            TxtSegundoNombre.Text = Factura.Cliente.SegundoNombre;
            TxtPrimerApellido.Text = Factura.Cliente.PrimerApellido;
            TxtSegundoApellido.Text = Factura.Cliente.SegundoApellido;
            TxtCorreo.Text = Factura.Cliente.Correo;
            TxtTelefono.Text = Factura.Cliente.Telefono;
            TxtDireccion.Text = Factura.Cliente.Direccion + " " + Factura.Cliente.Barrio.Nombre + " " + Factura.Cliente.Lugar.Ciudad;
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
            clienteservice = new ClienteService(ConfigConnection.ConnectionString);
            if(TxtPrimerApellido.Text.Equals("") || TxtPrimerNombre.Text.Equals("") ||  TxtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Por favor Complete los campos. ");
            }
            else
            {
               
                cliente.Direccion = Factura.Cliente.Direccion;
                cliente.Lugar = Factura.Cliente.Lugar;
                cliente.Barrio = Factura.Cliente.Barrio;
                cliente = Factura.Cliente;
                cliente.PrimerNombre = TxtPrimerNombre.Text.Trim().ToUpper();
                cliente.SegundoNombre = TxtSegundoNombre.Text.Trim().ToUpper();
                cliente.PrimerApellido = TxtPrimerApellido.Text.Trim().ToUpper();
                cliente.SegundoApellido = TxtSegundoApellido.Text.Trim().ToUpper();
                cliente.Correo = TxtCorreo.Text.Trim().ToUpper();

                
                cliente.Telefono = TxtTelefono.Text;
                
       
               

                    MessageBox.Show(clienteservice.ModificarCliente(cliente));
                    Factura.Cliente = null;
                    Factura.AgregarCliente(cliente);
                   
                
               
            }
        }

        

        public void Txtdirection()
        {
            TxtDireccion.Text = CB1.Text + " " + CB2.Text + " " + CB3.Text + " " + CB4.Text + " " + CB5.Text + " " + CB6.Text
                + " " + CmbCiudad.Text + " " + CmbBarrio.Text;
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

        private void CmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lugarservice = new LugarService(ConfigConnection.ConnectionString);
            CmbBarrio.Enabled = true;
            LlenarComboBarrio(CmbCiudad.Text);
            foreach (var item in Barrios)
            {
                if (item.Nombre.Equals(CmbBarrio.Text))
                {
                    Factura.Cliente.Barrio = item;
                }
            }
            foreach (var item in Lugares)
            {
                if (item.Ciudad.Equals(CmbCiudad.Text))
                {
                    Factura.Cliente.Lugar = item;
                }
            }
            Txtdirection();
        }

        private void LlenarComboLugar()
        {
            lugarservice = new LugarService(ConfigConnection.ConnectionString);
            Lugares = lugarservice.ConsultarLugares();
            CmbCiudad.Items.Clear();
            foreach (var item in Lugares)
            {
                CmbCiudad.Items.Add(item.Ciudad);
            }
        }
        private void LlenarComboBarrio(string nombre)
        {
            Barrios = new List<Barrio>();
            CmbBarrio.Items.Clear();
            foreach (var item in Lugares)
            {
                if (item.Ciudad.Equals(CmbCiudad.Text))
                {
                    CmbBarrio.Items.Add(item.Barrio.Nombre);
                    Barrios.Add(item.Barrio);
                }
            }
        }

        private void CmbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }
    }
}
