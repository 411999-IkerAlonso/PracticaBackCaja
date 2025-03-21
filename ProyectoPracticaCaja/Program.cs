using ProyectoPracticaCaja;
using System.Security.Cryptography;
Console.WriteLine("Presione 1 para iniciar una venta");
Console.WriteLine("Presione 0 para Salir");
int respuesta = Convert.ToInt32(Console.ReadLine());
do
{

    Pedido p1 = new Pedido();
    Producto prod1 = new Producto("Arroz", 1500);
    Producto prod2 = new Producto("yerba", 4200);
    Producto prod3 = new Producto("Cafe", 3000);
    int comando = 0;
    do
    {
        Console.WriteLine("Ingrese el codigo del producto");
        Console.WriteLine("1- Arroz");
        Console.WriteLine("2- Yerba");
        Console.WriteLine("3- Cafe");
        Console.WriteLine("0- Salir");
        comando = Convert.ToInt32(Console.ReadLine());
        if (comando == 1)
        {
            p1.AddProduct(prod1);
        }
        else if (comando == 2)
        {
            p1.AddProduct(prod2);
        }
        else if (comando == 3)
        {
            p1.AddProduct(prod3);
        }
    }
    while (comando > 0 && comando < 4);
    Console.WriteLine($"Total: ${p1.CalcularTotal()}");
    Console.WriteLine("Ingrese el dinero");
    double ingreso = Convert.ToDouble(Console.ReadLine());

    double DevolverCambio()
    {
        double cambio = ingreso - p1.CalcularTotal();
        return cambio;
    }
    Console.WriteLine($"Cambio: ${DevolverCambio()}");

    Historial_Ventas.GuardarVenta(p1, ingreso, DevolverCambio());
    Console.WriteLine("Presione 1 para iniciar una venta");
    Console.WriteLine("Presione 0 para Salir");
    respuesta = Convert.ToInt32(Console.ReadLine());
}
while (respuesta == 1);
