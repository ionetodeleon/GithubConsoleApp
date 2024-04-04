using System;

namespace GithubConsoleApp
{
    // A los vendedores se les da un premio por ventas
    enum Premio
    {
        Minimo = 100,
        Menor = 1000,
        Base = 2000,
        Mayor = 5000
    }

    class EnumExample
    {
        static void Main()
        {
            // Creamos un nuevo vendedor, le asignamos un premio por ventas + el sueldo base
            Vendedor vendedor = new Vendedor(Premio.Base, 25000.00);
            Console.WriteLine("El sueldo del vendedor es " + vendedor.ObtenerSueldo() + " pesos.");
        }
    }
    
}
