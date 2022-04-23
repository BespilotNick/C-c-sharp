// The program that checks the divisibility of the first number by the second

void IsDivNum()
{
    Console.WriteLine("Input first number:  ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second number:  ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 % num2 == 0)
    {
        Console.Write(num1 + " is a multiple of " + num2);
    }
    else
    {
        Console.Write(num1 + " is Not a multiple of " + num2);
    }
}
IsDivNum();

