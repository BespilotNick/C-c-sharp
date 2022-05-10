// Number of digits in usernumber

void NumberOfDigits(int a)
{
    if (a < 0)
        a = a * (-1);

    int count = 0;

    while (a > 0)
    {
        a = a / 10;
        count++;
    }
    
    if (count > 0)
        Console.WriteLine("Number of digits in your number is " + count);
    else
        Console.WriteLine("Your number is '0', so number of digits = 1");
}

Console.WriteLine("Input your number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

NumberOfDigits(usernum);