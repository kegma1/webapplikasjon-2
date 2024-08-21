class TaskA
{
    private static void Main()
    {
        Console.Write("Enter length: ");
        var width = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Enter height: ");
        var height = Convert.ToDecimal(Console.ReadLine());

        var area = width * height;
        var circumference = (width * 2) + (height * 2);
        
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circumference: " + circumference);
    }
}