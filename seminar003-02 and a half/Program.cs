//

int FindQuart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;

    else if(x < 0 && y > 0)
        return 2;

    else if(x < 0 && y < 0)
        return 3;

    else if(x > 0 && y < 0)
        return 4;

    else
        return 0;
}

Console.WriteLine("Input coordinate X: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Y: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(x: xDot, y: yDot);

if (quartNum == 0)
    Console.WriteLine("Dot located on the axes!");
else
    Console.WriteLine("Numder of quarter is " + quartNum);

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

// Console.WriteLine("Input number of quarter is: ");
// int numQuart = Convert.ToInt32(Console.ReadLine());

//PointRange(FindQuart(x: xDot, y: yDot));

PointRange(quartNum);