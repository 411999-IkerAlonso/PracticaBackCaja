using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPracticaCaja
{
    
    class Historial_Ventas
    {
        private static readonly string Ruta = "C:\\Users\\usuario\\Desktop\\KIKER\\PRACTICA PROGRAMACION\\BACK\\ProyectoPracticaCaja\\Historial_ventas.txt";
        public Historial_Ventas()
        {

        }

     
       public static void GuardarVenta(Pedido pedido, double ingreso, double cambio)
        {
            using (StreamWriter sw = new StreamWriter(Ruta, true))
            {
                sw.WriteLine($"[{DateTime.Now}] Venta Realizada:");
                foreach (var producto in pedido.Productos)
                {
                    sw.WriteLine($"- {producto.Name}: ${producto.Price}");
                }
                sw.WriteLine($"Total: ${pedido.CalcularTotal()}");
                sw.WriteLine($"Pago: ${ingreso}");
                sw.WriteLine($"Cambio: ${cambio}");
                sw.WriteLine(new string('-', 30));
            }
        }
    }
}
