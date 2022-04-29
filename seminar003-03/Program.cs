// Distanse between two points in CoordSystem X, Y
// 

double DistPoints(double A, double B)
{
    double result = Math.Sqrt(A * A + B * B);

    return result;
}

Console.WriteLine("Input coordinate X for pooint A");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Y for pooint A");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate X for pooint B");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Y for pooint B");
int By = Convert.ToInt32(Console.ReadLine());

double distX = Bx - Ax;
double distY = By - Ay;

double distance = DistPoints(distX, distY);
Console.WriteLine("Distance between points A and B = " + distance);