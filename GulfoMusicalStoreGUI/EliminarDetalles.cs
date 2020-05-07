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
    public partial class EliminarDetalles : Form
    {
        private CursoService cursoservice;
        public Factura Factura { get; set; }
        public IVenta Venta { get; set; }
        public EliminarDetalles(Factura factura)
        {
            InitializeComponent();
            Factura = factura;
            labelTotal.Visible = false;
            TxtTotalCursosAcusticas.Visible = false;
            DesactivarProductos();
            DesactivarCursos();
            LlenarComboProducto();
            LlenarCursos();
        }

        private void LlenarCursos()
        {
            cursoservice = new CursoService();
            foreach (var item in cursoservice.ConsultarCursos())
            {
                CmbCursos.Items.Add(item.Nombre);
            }
        }

        private void LlenarComboProducto()
        {
            for (int i = 0; i < 200; i++)
            {
                CmbAcustica.Items.Add(i.ToString());
                CmbElectrica.Items.Add(i.ToString());
                CmbPiano.Items.Add(i.ToString());
                CmbBajo.Items.Add(i.ToString());
                CmbEliminarCursos.Items.Add(i.ToString());
            }
        }

        
        private void CalcularFactura()
        {
            CalcularGuitarrasAcusticas();
            CalcularGuitarrasElectricas();
            CalcularPianos();
            CalcularBajos();
        }

        private void CalcularGuitarrasAcusticas()
        {
            int numero = VerificarComboBox(CmbAcustica.Text);
            CalcularProducto("Guitarra Acustica", numero);
        }
        private void CalcularGuitarrasElectricas()
        {
            int numero = VerificarComboBox(CmbElectrica.Text);
            CalcularProducto("Guitarra Electrica", numero);
        }
        private void CalcularPianos()
        {
            int numero = VerificarComboBox(CmbPiano.Text);
            CalcularProducto("Piano", numero);
        }
        private void CalcularBajos()
        {
            int numero = VerificarComboBox(CmbBajo.Text);
            CalcularProducto("Bajo", numero);
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


        private void CalcularProducto(string nombreproducto, int numeroproductoseliminar)
        {
            IList<DetalleFactura> Detalles = Factura.VerListaProductos();
            int numeroproductosguardados = Detalles.Where(D => D.Producto.Nombre.Equals(nombreproducto)).ToList().Count;
            if (numeroproductosguardados < numeroproductoseliminar)
            {
                MessageBox.Show($"No se puede Eliminar este numero de {nombreproducto} ");
            }
            else
            {
                EliminarProductos(numeroproductoseliminar, nombreproducto);
            }
        }

        private void EliminarProductos(int numero, string nombre)
        {
            IList<DetalleFactura> Detalles = Factura.VerListaProductos();
            IList<DetalleFactura> Detalles2 = new List<DetalleFactura>();
            DetalleFactura detalle = null;
            for (int i = 0; i < numero; i++)
            {
                detalle=Detalles.Where(D => D.Producto.Nombre.Equals(nombre)).ElementAt(i);
                Detalles2.Add(detalle);
               
                
            }

            foreach (var item in Detalles2)
            {
                Factura.EliminarDetalleProductos(item);
            }
        }

        private void CalcularFacturaCursos()
        {
            CalcularCursos();
        }
        private void CalcularCursos()
        {
            int numerocursoseliminar = VerificarComboBox(CmbEliminarCursos.Text);
            string nombrecurso = CmbCursos.Text;
            IList<DetalleCurso> Detalles = Factura.VerListaCursos();
            int numerocursosguardados = Detalles.Where(D => D.Curso.Nombre.Equals(nombrecurso)).ToList().Count;
            if (numerocursosguardados < numerocursoseliminar)
            {
                MessageBox.Show($"No se puede Eliminar este numero de {nombrecurso} ");
            }
            else
            {
                EliminarCursos(numerocursoseliminar);
            }
        }
        private void EliminarCursos(int numero)
        {
            IList<DetalleCurso> DetalleCurso = Factura.VerListaCursos();
            IList<DetalleCurso> detalleCurso2 = new List<DetalleCurso>();
            DetalleCurso detallecurso = null;
            for (int i = 0; i < numero; i++)
            {
                detallecurso = DetalleCurso.Where(D => D.Curso.Nombre.Equals(CmbCursos.Text)).ElementAt(i);
                detalleCurso2.Add(detallecurso);
            }
            foreach (var item in detalleCurso2)
            {
                Factura.EliminarDetalleCursos(item);
            }
        }

        private void CmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEliminar.Text == "Cursos")
            {
                DesactivarProductos();
                ActivarCursos();
            }
            if (CmbEliminar.Text == "Productos")
            {
                DesactivarCursos();
                ActivarProductos();
            }
        }

        private void DesactivarCursos()
        {
            labelCurso.Visible = false;
            CmbCursos.Visible = false;
            labelTotalEliminar.Visible = false;
            CmbEliminarCursos.Visible = false;
        }

        private void ActivarCursos()
        {
            labelCurso.Visible = true;
            CmbCursos.Visible = true;
            labelTotalEliminar.Visible = true;
            CmbEliminarCursos.Visible = true;
            labelTotal.Visible = true;
            TxtTotalCursosAcusticas.Visible = true;
        }

        private void DesactivarProductos()
        {
            CmbAcustica.Visible = false;
            labelAcustica.Visible = false;
            CmbElectrica.Visible = false;
            labelElectrica.Visible = false;
            CmbPiano.Visible = false;
            labelPiano.Visible = false;
            CmbBajo.Visible = false;
            labelBajo.Visible = false;
            labelProductos.Visible = false;
            TxtElectrica.Visible = false;
            TxtPiano.Visible = false;
            TxtBajo.Visible = false;
        }
        private void ActivarProductos()
        {
            CmbAcustica.Visible = true;
            labelAcustica.Visible = true;
            CmbElectrica.Visible = true;
            labelElectrica.Visible = true;
            CmbPiano.Visible = true;
            labelPiano.Visible = true;
            CmbBajo.Visible = true;
            labelBajo.Visible = true;
            labelProductos.Visible = true;
            TxtElectrica.Visible = true;
            TxtPiano.Visible = true;
            TxtBajo.Visible = true;
            TxtTotalCursosAcusticas.Visible = true;
            labelTotal.Visible = true;
            ActualizarTxt();
        }

        private void ActualizarTxt()
        {
            TxtTotalCursosAcusticas.Text = ContarProductos("Guitarra Acustica").ToString();
            TxtElectrica.Text = ContarProductos("Guitarra Electrica").ToString();
            TxtPiano.Text = ContarProductos("Piano").ToString();
            TxtBajo.Text = ContarProductos("Bajo").ToString();
        }

        private int ContarProductos(string nombre)
        {
           return Factura.VerListaProductos().
                Where(D => D.Producto.Nombre.Equals(nombre)).ToList().Count;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CalcularFactura();
            CalcularFacturaCursos();
            Venta.TotalVenta(Factura);
            MessageBox.Show("Se han eliminado. ");
            this.Close();
        }

        private void CmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
           TxtTotalCursosAcusticas.Text= Factura.VerListaCursos().
                Where(D => D.Curso.Nombre.Equals(CmbCursos.Text)).ToList().Count.ToString();
        }
    }
}
