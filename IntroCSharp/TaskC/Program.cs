class TaskC
{
    private static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Not enough arguments supplied");
            return;
        }
        
        var temp = Convert.ToDouble(args[0]);
        var unit = args[1];

        if (unit == "C" || unit == "c")
        {
            var fahrenheit = TempConverter.CelciusToF(temp);
            Console.WriteLine($"{fahrenheit} \u00b0F");
            return;
        }

        if (unit == "F" || unit == "f")
        {
            var celsius = TempConverter.FahrenheitToC(temp);
            Console.WriteLine($"{celsius} \u00b0C");
            return;
        }
    }
}

internal static class TempConverter
{
    public static double CelciusToF(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public static double FahrenheitToC(double f)
    {
        return (f - 32) * 5 / 9;
    }
}