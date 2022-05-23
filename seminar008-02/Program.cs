// Write a method that changes rows and columns

Console.WriteLine("Input number of row and columns in matrix (matrix MUST be square!): ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] ChangeRowCol(int[,] matrix)
{
    int[,] invertMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            invertMatrix[i, j] = matrix[j, i];
            Console.Write(invertMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return invertMatrix;
}

ChangeRowCol(matrix);