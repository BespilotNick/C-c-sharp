// Write a method that canges first and last rows in matrix

Console.WriteLine("Input number of row in matrix: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns in matrix: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, col];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = new Random().Next(0, 20);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] FirstToLastRow(int[,] matrix)
{
    int[,] changedmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
                changedmatrix[i, j] = matrix[(matrix.GetLength(0) - 1), j];
            else if (i == (matrix.GetLength(0) - 1))
                changedmatrix[i, j] = matrix[0, j];
            else
                changedmatrix[i, j] = matrix[i, j];
            Console.Write(changedmatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
    return changedmatrix;
}

FirstToLastRow(matrix);

