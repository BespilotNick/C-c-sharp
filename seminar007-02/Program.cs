// Создать двумерный массив, написать метод, который возводит в квадрат элементы с обоими четными индексами

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

void ModiMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
                matrix[i, j] *= matrix[i, j];
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Input number of rows:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns:  ");
int col = Convert.ToInt32(Console.ReadLine());
ModiMatrix(CreateMatrix(row, col));