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
    public partial class FrmComprarCurso : Form
    {
        private CursoService cursoService;
        public IVenta Venta { get; set; }
        public Factura Factura { get; set; }
        public FrmComprarCurso(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            AñadirComboBox();
            for (int i = 0; i < 100; i++)
            {
                CmbUnidades.Items.Add(i.ToString());
            }
        }


        private void AñadirComboBox()
        {
            cursoService = new CursoService();
            foreach (var item in cursoService.ConsultarCursos())
            {
                CmbNombreCurso.Items.Add($"{item.Nombre}");
            }
        }


        private int VerificarComboBox(string numerocombo)
        {
            int numero;
            try
            {
                return numero = int.Parse(numerocombo);
            }
            catch (Exception e)
            {
                return numero = 0;
            }

        }
        private void AgregarCursos()
        {
            cursoService = new CursoService();
            int numero = VerificarComboBox(CmbUnidades.Text);
            if (cursoService.BuscarCurso(CmbNombreCurso.Text)==null)
            {
                MessageBox.Show("No se encontro en la lista. ");
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    Curso curso = null;
                    curso = cursoService.BuscarCurso(CmbNombreCurso.Text);
                    Factura.AgregarDetalleCurso(curso);
                }
            }
        }
        

       

        private void CmbNombreCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbUnidades.Text == "")
            {
                MessageBox.Show("Seleccione cuantas unidades llevara. ");
            }
            
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        { 
            if(CmbNombreCurso.Text=="" || CmbUnidades.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios. ");
            }
            else
            {
                AgregarCursos();
                Venta.TotalVenta(Factura);
                MessageBox.Show("Se han añadido los cursos a la factura. ");
                this.Close();
            }
        }

        private void CmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbNombreCurso.Text == "")
            {
                MessageBox.Show("Seleccione el Curso");
            }
            
        }
    }
}
