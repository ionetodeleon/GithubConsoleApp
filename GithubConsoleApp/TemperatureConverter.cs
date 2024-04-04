namespace GithubConsoleApp
{
    public static class TemperatureConverter
    {
        public static double CelsiusAFahrenheit(string temperaturaCelsius)
        {
            // Convertir argumento a double para cálculos.
            double celsius = Double.Parse(temperaturaCelsius);

            // Convertir Celsius a Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitACelsius(string temperaturaFahrenheit)
        {
            // Convertir argumento a double para cálculos.
            double fahrenheit = Double.Parse(temperaturaFahrenheit);

            // Convertir Fahrenheit a Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}
