// Write a mathod to reverse single massive

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

/*
int[] ReverseArray(int[] array)
{
    int[] revArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        revArray[i] = array[(array.Length - 1) - i];
    return revArray;
}
*/

int[] ReverseArray(int[] array)
{
    int[] revArray = new int[array.Length];

    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        revArray[i] = array[j];
    return revArray;
}

int size = 20;
int min = -100;
int max = 100;
int[] newArray = CreateArray(size, min, max);
ShowArray(newArray);
Console.WriteLine();
Console.Write("Reversed Array is:  ");
ShowArray(ReverseArray(newArray));