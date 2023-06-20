void Palindrom5(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num % 10000 / 1000;
    int fourthDigit = num % 100 / 10;
    int fifthDigit = num % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        Console.Write($"Your number {num} is a palindrom");
    else Console.Write($"Your number {num} isn't a palindrom");
}
Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000 || number < -9999 && number > - 100000)
    Palindrom5(number);
else Console.Write("Error! It's not a five-digit number. Try again!");