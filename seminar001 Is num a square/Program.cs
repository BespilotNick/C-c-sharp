/*
Console.Write("Input first integer number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input srcond integer number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2*num2;

if (num1 == quad)
{
    Console.WriteLine("First numbur is a square of the second number");
}
else
{
    Console.WriteLine("First numbur is NOT a square of the second number");
}
*/

Console.Write("Input first integer number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input srcond integer number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2)
    Console.WriteLine("First numbur is a square of the second number");
else
    Console.WriteLine("First numbur is NOT a square of the second number");
