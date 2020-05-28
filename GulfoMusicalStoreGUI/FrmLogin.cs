using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (TxtUsuario.Text == "Admin" && TxtContraseña.Text == "ABC123")
            {
                TxtUsuario.Text = "Usuario";
                TxtContraseña.Text = "Contraseña";
                this.SetVisibleCore(false);
                FrmBienvenida frmBienvenida = new FrmBienvenida();
                frmBienvenida.Show();
            }
            else
            {
                MessageBox.Show("Usuario / Contraseña errada","Información", 
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
                PBVerContraseña.Image = Image.FromFile(@"C:\Users\norma\source\repos\normacocsub\GulfoMusicalStore\Recursos\Ver.png");
            }
            else
            {
                TxtContraseña.UseSystemPasswordChar = true;
                PBVerContraseña.Image = Image.FromFile(@"C:\Users\norma\source\repos\normacocsub\GulfoMusicalStore\Recursos\NoVer.png");
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTienda frmTienda = new FrmTienda();
            frmTienda.Show();
        }
    }
}
