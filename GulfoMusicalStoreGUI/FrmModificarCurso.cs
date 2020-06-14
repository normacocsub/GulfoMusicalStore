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
    public partial class FrmModificarCurso : Form
    {
        private CursoService cursoservice;
        public static IList<Curso> Cursos { get; set; }
        public ICurso ICurso { get; set; }
        public FrmModificarCurso()
        {
            InitializeComponent();
            LLenarCombo();
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
                    TxtPrecio.Text = item.Total.ToString();
                    CmbEstado.Text = item.Estado;
                    TxtNombre.Text = item.Nombre;
                }
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            if(CmbCurso.Text.Equals("") || TxtCodigo.Text.Equals("") || TxtPrecio.Text.Equals("") || CmbEstado.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos.");
            }
            else
            {
                try
                {
                    decimal precio = decimal.Parse(TxtPrecio.Text);
                    Curso curso = new Curso();
                    curso = cursoservice.BuscarCurso(TxtCodigo.Text);
                    curso.Total = precio;
                    curso.Estado = CmbEstado.Text;
                    curso.Nombre = TxtNombre.Text;
                    MessageBox.Show(cursoservice.ModificarCurso(curso));
                    ICurso.Actualizar();
                    this.Close();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show($"Error. {ex.Message.ToString()}");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
