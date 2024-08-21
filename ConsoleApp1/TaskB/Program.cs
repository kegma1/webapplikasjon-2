class TaskB
{
    private static void Main()
    {
        Console.Write("Enter your height: ");
        var height = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter your weight: ");
        var weight = Convert.ToDouble(Console.ReadLine());

        var bmi = weight / (height * height);
        
        if (bmi < 18.5)
        {
            Console.WriteLine($"Your BMI is {bmi}. you are under weight.");
        } 
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine($"Your BMI is {bmi}. you are normal weight.");
        } 
        else if (bmi >= 25.0 && bmi <= 29.9)
        {
            Console.WriteLine($"Your BMI is {bmi}. you are over weight.");
        }
        else if (bmi >= 30)
        {
            Console.WriteLine($"Your BMI is {bmi}. you are obese.");
        }
    }
}