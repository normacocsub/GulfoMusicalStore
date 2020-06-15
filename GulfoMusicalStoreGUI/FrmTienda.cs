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
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
            labelsede.Text = ConfigConnection.CiudadConectada;
        }
        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AbrirContainer(object abrircontainer)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form ac = abrircontainer as Form;
            ac.TopLevel = false;
            ac.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(ac);
            this.PanelContenedor.Tag = ac;
            ac.Show();
        }

        private void BtnInventario_Click_1(object sender, EventArgs e)
        {
            AbrirContainer(new FrmInventario());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = false;
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
                AbrirContainer(new FrmVenta());
                BtnVenta.Enabled = false;
                BtnInventario.Enabled = true;
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            AbrirContainer(new FrmFacturas());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = true;
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            AbrirContainer(new FrmCurso());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = true;
        }

        private void BtnCursos_Click(object sender, EventArgs e)
        {
            AbrirContainer(new FrmClientes());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = true;
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirContainer(new FrmEstadisticas());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = true;
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1) this.Opacity += 0.10;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            AbrirContainer(new FrmLogo());
            BtnVenta.Enabled = true;
            BtnInventario.Enabled = true;
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            BtnLogo_Click(null, e);
        }
    }
}
