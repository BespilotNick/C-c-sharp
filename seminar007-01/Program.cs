// Создать двумерный массив размером usernum1 и usernum2 и заполнить их суммами индексов собственных элементов

void CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = i + j;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns:  ");
int col = Convert.ToInt32(Console.ReadLine());

CreateMatrix(row, col);