using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPracticaCaja
{
    public class Pedido
    {
        public List<Producto> Productos { get; set; }
        public int Cantidad { get; set; }
       
        public Pedido()
        {
            Productos = new List<Producto>();
            Cantidad = 0;
        }

        public Pedido(List<Producto> productos, int cantidad)
        {
            this.Productos = productos;
            this.Cantidad = cantidad;

        }

        public double CalcularTotal()
        {
            double Total = Productos.Sum(p => p.Price);
            return Total;
        }

        public void AddProduct(Producto product)
        {
            Productos.Add(product);
        }
    }
}
