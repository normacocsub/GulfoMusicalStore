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
        public static IList<Curso> Cursos { get; set; }
        public FrmComprarCurso(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            AñadirComboBox();
        }


        private void AñadirComboBox()
        {
            cursoService = new CursoService(ConfigConnection.ConnectionString);
            Cursos = cursoService.ConsultarCursos();
            foreach (var item in Cursos)
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
            cursoService = new CursoService(ConfigConnection.ConnectionString);
            int opcion=5;
            try
            {
                DetalleCurso detalle = null;
                int numero = VerificarComboBox(TxtUnidades.Text);
                foreach (var item in Cursos)
                {
                    if (item.Nombre.Equals(CmbNombreCurso.Text))
                    {
                        
                        foreach (var item2 in Factura.VerListaCursos())
                        {
                            if (item2.Curso.Nombre.Equals(CmbNombreCurso.Text))
                            {
                                detalle = item2;
                                opcion = 1;
                            }
                            
                        }
                        if (Factura.VerListaCursos().Where(C=>C.Curso.Nombre.Equals(CmbNombreCurso.Text)).ToList().Count == 0)
                        {
                            opcion = 0;
                        }
                        if (opcion == 0)
                        {
                            Factura.AgregarDetalleCurso(item, numero);
                        }
                    }

                    if (opcion == 1 && item.Nombre.Equals(CmbNombreCurso.Text))
                    {
                        Factura.DetallesCursoFactura.Remove(detalle);
                        Factura.AgregarDetalleCurso(item, numero);
                    }

                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Error. {ex.Message.ToString()}");
            }
            
        }
        

       


        private void BtnFacturar_Click(object sender, EventArgs e)
        { 
            if(CmbNombreCurso.Text=="" || TxtUnidades.Text == "")
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
