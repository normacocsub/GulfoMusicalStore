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
    public partial class FrmClienteDatos : Form
    {
        public iUnlockVenta UnlockVenta { get; set; }
        private ClienteService clienteservice;
        private LugarService lugarservice;
        public IVenta Venta { get; set; }
        public Factura Factura { get; set; }
        public FrmClienteDatos(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            DesactivarTxt();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (Factura.Cliente == null)
            {
                if (TxtCedula.Text.Equals("") || TxtPrimerNombre.Text.Equals("")
                       || TxtPrimerApellido.Text.Equals("") || TxtCorreo.Text.Equals("")
                       || CB1.Text.Equals("") || CB2.Text.Equals("")
                       || CB3.Text.Equals("") || CB4.Text.Equals("") || CB5.Text.Equals("")
                       || CB6.Text.Equals("") || TxtBarrio.Text.Equals(""))
                {
                    MessageBox.Show("Por Favor Complete los campos. ");
                }
                else
                {
                    RegistrarNuevoCLiente();
                    Venta.TotalVenta(Factura);
                    UnlockVenta.unlockventa();
                    this.Close();
                }

            }
            else
            {
                Venta.TotalVenta(Factura);
                this.Close();
            }
        }

        private void VaciarCampos()
        {
            TxtCedula.Text = "";
            TxtCorreo.Text = "";
            TxtPrimerApellido.Text = "";
            TxtPrimerNombre.Text = "";
            TxtSegundoApellido.Text = "";
            TxtSegundoNombre.Text = "";
            TxtCorreo.Text = "";
        }

        private void RegistrarNuevoCLiente()
        {
            clienteservice = new ClienteService(ConfigConnection.ConnectionString);
            Cliente cliente=null;
            
            string  primernombre, segundonombre, primerapellido, segundoapellido,  correo;
            string  direccion;
            string cedula, telefono;

            

            primernombre = (TxtPrimerNombre.Text).Trim().ToUpper();
            segundonombre = TxtSegundoNombre.Text.Trim().ToUpper();
            primerapellido = TxtPrimerApellido.Text.Trim().ToUpper();
            segundoapellido = TxtSegundoApellido.Text.Trim().ToUpper();
            correo = TxtCorreo.Text.Trim().ToUpper();
            cedula = TxtCedula.Text;
            telefono = TxtTelefono.Text;

            direccion = CB1.Text + " " + CB2.Text + " " + CB3.Text + " " + CB4.Text + " " + CB5.Text + " " + CB6.Text;

            cliente = new Cliente();
            cliente.Cedula = cedula;
            cliente.PrimerNombre = primernombre;
            cliente.SegundoNombre = segundonombre;
            cliente.PrimerApellido = primerapellido;
            cliente.SegundoApellido = segundoapellido;
            cliente.Correo = correo;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;

            cliente.Barrio = TxtBarrio.Text;

            Lugar lugar = new Lugar();
            lugar.Codigo = ConfigConnection.Codigo;
            lugar.Ciudad = ConfigConnection.CiudadConectada;
            cliente.AgregarLugar(lugar);
            MessageBox.Show(clienteservice.GuardarCLiente(cliente));


            Factura.AgregarCliente(cliente);
            
        }

        private void BtnBuscarCedula_Click(object sender, EventArgs e)
        {
            clienteservice = new ClienteService(ConfigConnection.ConnectionString);
            if (TxtCedulaBuscar.Text.Equals(""))
            {
                MessageBox.Show("Por favor complete el campo. ");
            }
            else
            {
                try
                {
                    Cliente cliente=null;
                    int numero;
                    numero = int.Parse(TxtCedulaBuscar.Text);
                    if((clienteservice.BuscarCliente(numero.ToString())) == null)
                    {
                        VaciarCampos();
                        
                        TxtCedula.Text = TxtCedulaBuscar.Text;
                        ActivarTxt();
                        TxtCedula.Enabled = false;
                        MessageBox.Show("Por favor llene los campos. ");
                    }
                    else
                    {
                        
                        cliente = clienteservice.BuscarCliente(numero.ToString());
                        DesactivarTxt();
                        TxtCedula.Text = cliente.Cedula;
                        
                        TxtPrimerNombre.Text = cliente.PrimerNombre;
                        TxtSegundoNombre.Text = cliente.SegundoNombre;
                        TxtPrimerApellido.Text = cliente.PrimerApellido;
                        TxtSegundoApellido.Text = cliente.SegundoApellido;
                        TxtCorreo.Text = cliente.Correo;
                        TxtTelefono.Text = cliente.Telefono;
                        TxtDireccion.Text = cliente.Direccion + " " + cliente.Barrio + " " + cliente.Lugar.Ciudad;
                    }
                    Factura.AgregarCliente(cliente);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Verifique que la cedula no tenga letras ni espacios. " + ex.Message.ToString());
                }

            }
        }

        private void ActivarTxt()
        {
            TxtPrimerNombre.Enabled = true;
            TxtPrimerApellido.Enabled = true;
            TxtSegundoApellido.Enabled = true;
            TxtSegundoNombre.Enabled = true;
            TxtCedula.Enabled = true;
            TxtCorreo.Enabled = true;
            TxtTelefono.Enabled = true;
        }
        private void DesactivarTxt()
        {
            TxtPrimerNombre.Enabled = false;
            TxtPrimerApellido.Enabled = false;
            TxtSegundoApellido.Enabled = false;
            TxtSegundoNombre.Enabled = false;
            TxtCorreo.Enabled = false;
            TxtCedula.Enabled = false;
            TxtTelefono.Enabled = false;
        }

        public void Txtdirection()
        {
            TxtDireccion.Text = CB1.Text + " " + CB2.Text + " " + CB3.Text + " " + CB4.Text + " " + CB5.Text + " " + CB6.Text
                 + " " + TxtBarrio.Text;
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

        private void TxtBarrio_TextChanged(object sender, EventArgs e)
        {
            Txtdirection();
        }
    }
}
