using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GulfoMusicalStoreGUI
{
    public partial class FrmLogin : Form
    {
        public FacturaService facturaservice;
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string estado;
            int estad02 = 0;
            if (TxtUsuario.Text == "Bogota" && TxtContraseña.Text == "ABC123")
            {
                TxtUsuario.Text = "Usuario";
                TxtContraseña.Text = "Contraseña";
                this.SetVisibleCore(false);
                ConfigConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                ConfigConnection.CiudadConectada = "Bogota";
                ConfigConnection.Codigo = 1;
                facturaservice = new FacturaService(ConfigConnection.ConnectionString);
                estado = facturaservice.PruebaConexion();
                FrmBienvenida frmBienvenida = new FrmBienvenida(estado);
                frmBienvenida.Show();
                estad02 = 1;
            }
            if (TxtUsuario.Text == "Cali" && TxtContraseña.Text == "ABC123")
            {
                TxtUsuario.Text = "Usuario";
                TxtContraseña.Text = "Contraseña";
                this.SetVisibleCore(false);
                ConfigConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                ConfigConnection.CiudadConectada = "Cali";
                ConfigConnection.Codigo = 2;
                facturaservice = new FacturaService(ConfigConnection.ConnectionString);
                estado = facturaservice.PruebaConexion();
                FrmBienvenida frmBienvenida = new FrmBienvenida(estado);
                frmBienvenida.Show();
                estad02 = 1;
            }
            if (TxtUsuario.Text == "Barranquilla" && TxtContraseña.Text == "ABC123")
            {
                TxtUsuario.Text = "Usuario";
                TxtContraseña.Text = "Contraseña";
                this.SetVisibleCore(false);
                ConfigConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection3"].ConnectionString;
                ConfigConnection.CiudadConectada = "Barranquilla";
                ConfigConnection.Codigo = 3;
                facturaservice = new FacturaService(ConfigConnection.ConnectionString);
                estado = facturaservice.PruebaConexion();
                FrmBienvenida frmBienvenida = new FrmBienvenida(estado);
                frmBienvenida.Show();
                estad02 = 1;
            }
            if(estad02==0)
            {
                TxtUsuario.Text = "Usuario";
                TxtContraseña.Text = "Contraseña";
                MessageBox.Show("Usuario / Contraseña errada", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Administrador")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Administrador";
                TxtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.DimGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void LabelRecuperarContraseña_Click(object sender, EventArgs e)
        {
            this.Opacity=0;
            FrmRecuperarContraseña frmRecuperar = new FrmRecuperarContraseña();
            frmRecuperar.Show();
        }

        private void PBVerContraseña_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.UseSystemPasswordChar == true)
            {
                TxtContraseña.UseSystemPasswordChar = false;
                PBVerContraseña.Image = Image.FromFile(ConfigConnection.Direccion + @"\Recursos\Ver.png");
            }
            else
            {
                TxtContraseña.UseSystemPasswordChar = true;
                PBVerContraseña.Image = Image.FromFile(ConfigConnection.Direccion + @"\Recursos\NoVer.png");
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTienda frmTienda = new FrmTienda();
            frmTienda.Show();
        }

        private void CmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
