using System;

namespace GithubConsoleApp
{
    class Programa
    {
        static void Main2()
        {
            Console.WriteLine("Por favor seleccione la dirección del convertidor");
            Console.WriteLine("1. De Celsius a Fahrenheit.");
            Console.WriteLine("2. De Fahrenheit a Celsius.");
            Console.Write(": ");

            string? seleccion = Console.ReadLine();
            double F, C;

            switch (seleccion)
            {
                case "1":
                    Console.Write("Por favor ingrese la temperatura en Celsius: ");
                    F = TemperatureConverter.CelsiusAFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperatura en Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Por favor ingrese la temperatura en Fahrenheit: ");
                    C = TemperatureConverter.FahrenheitACelsius(Console.ReadLine());
                    Console.WriteLine("Temperatura en Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Por favor seleccione un convertidor.");
                    break;
            }
        }
    }
}
