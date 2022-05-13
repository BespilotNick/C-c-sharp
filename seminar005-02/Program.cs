// Create an array, found if a defind number in the array

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max+1);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void IfNumInArray(int a, int[] array)
{
    int coinc = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
            coinc += 1;
    }

    if (coinc > 0)
        Console.WriteLine("Your number is IN array )");
    else
        Console.WriteLine("Your number is NOT in array (");
}

int size = 18;
int min = -50;
int max = 50;
Console.WriteLine("Input your number in range from " + min + " to " + max);
int usernum = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size, min, max);
if (usernum > min && usernum < max)
{
    PrintArray(myArray);
    IfNumInArray(usernum, myArray);
}
else
    Console.WriteLine("Your number is OUT of range, please select a number between " + min + " and " + max);