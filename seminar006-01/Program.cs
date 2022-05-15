//

bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    return false;
}

Console.WriteLine("Input length of side 1: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length of side 2: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length of side 3: ");
int side3 = Convert.ToInt32(Console.ReadLine());

if (IsTriangleExist(side1, side2, side3))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");