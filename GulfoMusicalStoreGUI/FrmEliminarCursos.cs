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
    public partial class FrmEliminarCursos : Form
    {
        public static IList<Curso> Cursos { get; set; }
        public ICurso ICurso { get; set; }
        private CursoService cursoservice;
        public FrmEliminarCursos()
        {
            InitializeComponent();
            LLenarCombo();
        }

        private void BtmEliminar_Click(object sender, EventArgs e)
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            if (CmbCurso.Text.Equals("") || TxtCodigo.Text.Equals("") || TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos.");
            }
            else
            {
                Curso curso = new Curso();
                curso = cursoservice.BuscarCurso(TxtCodigo.Text);
                MessageBox.Show(cursoservice.EliminarCurso(curso));
                ICurso.Actualizar();
                this.Close();
            }
        }

        public void LLenarCombo()
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            Cursos = cursoservice.ConsultarCursos();
            CmbCurso.Items.Clear();
            foreach (var item in Cursos)
            {
                CmbCurso.Items.Add(item.Nombre);
            }
        }

        private void CmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            Cursos = cursoservice.ConsultarCursos();
            foreach (var item in Cursos)
            {
                if (item.Nombre.Equals(CmbCurso.Text))
                {
                    TxtCodigo.Text = item.Codigo;
                    TxtNombre.Text = item.Nombre;
                }
            }
        }
    }
}
