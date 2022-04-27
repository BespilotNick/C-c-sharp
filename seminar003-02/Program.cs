//

void PointRange(int a)
{
    if(a == 1)
    {
        Console.WriteLine("This quarter contains points in range: X > 0, Y > 0");
    }

    else if(a == 2)
    {
        Console.WriteLine("This quarter contains points in range: X < 0, Y > 0");
    }

    else if(a == 3)
    {
        Console.WriteLine("This quarter contains points in range: X < 0, Y < 0");
    }

    else if(a == 4)
    {
        Console.WriteLine("This quarter contains points in range: X > 0, Y < 0");
    }

    else
        Console.WriteLine("Invalid Index! Please, Input numder of quarter in range from 1 to 4");
}

Console.WriteLine("Input number of quarter: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

PointRange(numQuart);