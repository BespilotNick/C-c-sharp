//  Finding the quarter of coordinate sistem

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