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
    public partial class FrmCurso : Form,ICurso
    {
        private CursoService cursoservice;
        public FrmCurso()
        {
            InitializeComponent();
            MapearTabla(DtgCurso);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            if(TxtInstrumento.Text.Equals("") || CmbEstado.Text.Equals("") || TxtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos. ");
            }
            else
            {
                try
                {
                    decimal precio = decimal.Parse(TxtPrecio.Text);
                    Curso curso = new Curso();
                    curso.Total = precio;
                    curso.Nombre = TxtInstrumento.Text;
                    curso.Estado = CmbEstado.Text;
                    curso.FechaCreacion = DateTime.Now;
                    MessageBox.Show(cursoservice.GuardarCurso(curso));
                    MapearTabla(DtgCurso);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Error. " + ex.Message.ToString());
                }
            }
        }

        private void MapearTabla(DataGridView dtg)
        {
            cursoservice = new CursoService(ConfigConnection.ConnectionString);
            dtg.Rows.Clear();
            foreach (var item in cursoservice.ConsultarCursos())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Codigo;
                dtg.Rows[n].Cells[1].Value = item.Nombre;
                dtg.Rows[n].Cells[2].Value = item.Total;
                dtg.Rows[n].Cells[3].Value = item.Estado;
                dtg.Rows[n].Cells[4].Value = item.FechaCreacion;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MapearTabla(DtgCurso);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarCurso frmmodi = new FrmModificarCurso();
            frmmodi.ICurso = this;
            frmmodi.Show();
        }

        public void Actualizar()
        {
            MapearTabla(DtgCurso);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCursos FrmElimCursos = new FrmEliminarCursos();
            FrmElimCursos.ICurso = this;
            FrmElimCursos.Show();
        }
    }
}
