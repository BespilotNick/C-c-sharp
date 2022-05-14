// Create an array (15 random digits), find quantity of elements that layed in range from 30 to 90

int size = 15;
int min = 0;
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

int ElementsInRange(int[] array)
{
    int Elts = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 30 && array[i] < 90)
            Elts += 1;
    }
    
    return Elts;
}

int[] randArray = CreateArray(size, min, max);
ShowArray(randArray);
Console.WriteLine("There are " + ElementsInRange(randArray) + " elements of array in range from 30 to 90");