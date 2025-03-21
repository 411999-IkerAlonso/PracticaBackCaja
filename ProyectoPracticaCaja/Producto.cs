using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPracticaCaja
{
    public class Producto
    {
        public string Name { get; set; }
        public double Price { get; set; }  
        
        public Producto() 
        {
            Name = string.Empty;
            Price = 0;
        }
        public Producto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
