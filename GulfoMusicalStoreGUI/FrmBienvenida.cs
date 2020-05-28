using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GulfoMusicalStoreGUI
{
    public partial class FrmBienvenida : Form
    {
        SoundPlayer Player;
        public FrmBienvenida()
        {
            InitializeComponent();
            Player = new SoundPlayer(@"C:\Users\norma\source\repos\normacocsub\GulfoMusicalStore\Recursos\Sonido.wav");
            Player.Play();
            this.Opacity = 0;
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start(); 
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if(this.Opacity==0)
            {
                timer2.Stop();
                this.Close();
                FrmTienda frmTienda = new FrmTienda();
                frmTienda.Show();
            }
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {
            //Con la base de datos haces que aparesca el usuario que ingresó.
        }
    }
}
