using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public DetalleFactura DetalleFactura { get; set; }
        public DetalleCurso DetalleCursoFactura { get; set; }
        public IList<DetalleFactura> DetallesFactura { get; set; }
        public IList<DetalleCurso> DetallesCursoFactura { get; set; }
        public Cliente Cliente { get; set; }
        public Curso Curso { get; set; }
        public Lugar Lugar { get; set; }

        public Factura()
        {
            DetallesFactura = new List<DetalleFactura>();
            DetallesCursoFactura = new List<DetalleCurso>();
        }

        public void AgregarDetalleFactura(Producto producto,int numero)
        {
            DetalleFactura = new DetalleFactura(producto);
            DetalleFactura.Factura = this;
            DetalleFactura.Unidades = numero;
            DetalleFactura.PrecioProducto = producto.Precio;
            DetallesFactura.Add(DetalleFactura);
        }

        public void AgregarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public decimal CalcularTotal()
        {
            return Total = SubTotal + Iva;
        }

        public decimal CalcularSubTotal()
        {
            SubTotal = (DetallesFactura.Sum(D => (D.Producto.Precio * D.Unidades)) +
                        DetallesCursoFactura.Sum(D => (D.Curso.Total * D.Unidades)));
            return SubTotal;
        }
        public decimal CalcularIVA()
        {
            Iva = (DetallesFactura.Sum(D => ((D.Producto.Precio * D.Unidades) * 0.19m)) +
                   DetallesCursoFactura.Sum(D => ((D.Curso.Total * D.Unidades) * 0.19m)));
            return Iva;
        }

        public int CalcularCantidad()
        {
            return Cantidad = DetallesFactura.Sum(P=>P.Unidades) + DetallesCursoFactura.Sum(C=>C.Unidades);
        }

        public void CalcularFactura()
        {
            CalcularSubTotal();
            CalcularIVA();
            CalcularCantidad();
            CalcularTotal();
        }
        public void AgregarDetalleCurso(Curso curso,int unidades)
        {
            DetalleCursoFactura = new DetalleCurso(curso);
            DetalleCursoFactura.Factura = this;
            DetalleCursoFactura.Precio = curso.Total;
            DetalleCursoFactura.Unidades = unidades;
            DetallesCursoFactura.Add(DetalleCursoFactura);
        }

        public IList<DetalleFactura> VerListaProductos()
        {
            return DetallesFactura;
        }

        public IList<DetalleCurso> VerListaCursos()
        {
            return DetallesCursoFactura;
        }

        public void LimpiarListaProductos()
        {
            DetallesFactura.Clear();
        }

        public void LimpiarListaCurso()
        {
            DetallesCursoFactura.Clear();
        }

        public Producto BuscarElemento(string id)
        {
            foreach (var item in DetallesFactura)
            {
                if (item.Producto.Codigo.Equals(id))
                {
                    return item.Producto;
                }
            }
            return null;
        }

        public void EliminarDetalleProductos(DetalleFactura Detalle)
        {
            DetallesFactura.Remove(Detalle);
        }

        public void EliminarDetalleCursos(DetalleCurso detalle)
        {
            DetallesCursoFactura.Remove(detalle);
        }

        public void CalcularTotalDetalles()
        {
            Cantidad = DetallesFactura.Count + DetallesCursoFactura.Count;
        }

        public void AgregarLugar(Lugar lugar)
        {
            Lugar = lugar;
        }


    }
}

