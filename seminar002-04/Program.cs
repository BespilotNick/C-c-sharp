// The program that checks if the first number multiple of 23 and 7 simultaneously

void IsMultSimult()
{
    Console.WriteLine("Input a number:  ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num % 23 == 0 && num % 7 == 0)
    {
        Console.WriteLine(num + " is multiple of 23 and 7");
    }
    else
    {
        Console.WriteLine(num + " is Not multiple of 23 and 7");
    }
}
IsMultSimult();
