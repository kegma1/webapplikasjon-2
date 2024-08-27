class TaskD {
    private static void Main(string[] args) {
        int x = Convert.ToInt32(args[0]);
        int y = Convert.ToInt32(args[1]);

        Swap(ref x, ref y);

        Console.WriteLine($"x: {x} \ny: {y}");

    }

    static void Swap(ref int i, ref int j) {
        int temp;
        temp = i;
        i = j;
        j = temp;
    }
}