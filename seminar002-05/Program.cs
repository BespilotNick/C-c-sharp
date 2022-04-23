// Is first number a square of the second number

void IsASquare()
{
    Console.WriteLine("Input first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num2 * num2 == num1)
    {
        Console.WriteLine(num1 + " IS a square of " + num2);
    }
    else
    {
        Console.WriteLine(num1 + " IS NOT a square of " + num2);
    }
}
IsASquare();