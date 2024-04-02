using System;

enum DiaDeLaSemana
{
    Domingo = 0,
    Lunes = 1,
    Martes = 2,
    Miercoles = 3,
    Jueves = 4,
    Viernes = 5,
    Sabado = 6
}

class Programa
{
    static void Main()
    {
        int valorDia = int.Parse(Console.ReadLine());

        DiaDeLaSemana dia = (DiaDeLaSemana)valorDia;
        Console.WriteLine("El día de la semana que elgiste es: " + dia);
    }
}
