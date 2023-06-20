void CubePrinter(int number)
{
    if (number >=1)
    {
        int current = 1;
        while (current <= number)
        {
            double cube = Math.Pow(current, 3);
            Console.Write($"{cube}, ");
            current++;
        }
    }
    if (number < 1)
    {
        int current = 1;
        while (current >= number)
        {
            double cube = Math.Pow(current, 3);
            Console.Write($"{cube}, ");
            current--;
        }
    }
    Console.WriteLine("\b\b.");
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
CubePrinter(num);
