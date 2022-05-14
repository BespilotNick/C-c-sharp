// Create a method that takes couple of elements (1, -1; 2, -2 ...) and multiplication of that elements

int size = 12;   // Required condition - size MUST be even
int min = -100;
int max = 100;

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void SymmetrMult(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int num1 = array[i];
        int num2 = array[array.Length - (i + 1)];
        int result = num1 * num2;
        Console.WriteLine("Multiplication №" + (i + 1) + " of " + num1 + " and " + num2 + " is: " + result);
    }
}


int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
Console.WriteLine();
SymmetrMult(myArray);