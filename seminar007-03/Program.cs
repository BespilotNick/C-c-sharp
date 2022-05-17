// Задать двумерный массив, найти сумму элементов на главной диагонали

int SumOfMainDiagonal(int[,] quad)
{
    int sum = 0;
    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i, i];
    }
    return sum;
}


Console.WriteLine("Input size of square matrix:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(SumOfMainDiagonal(matrix));