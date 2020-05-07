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
    public partial class FrmRecuperarContraseña : Form
    {
        public FrmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void BtnConfrimar_Click(object sender, EventArgs e)
        {
            //Haz que salga un mensaje de texto y diga se le ha enviado la contraseña a su correo.
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
