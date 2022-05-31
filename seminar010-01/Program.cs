// Метод для определения количества слов с четным числом букв

int CountOfEven(string[] mass)
{
    int count = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length % 2 == 0)
            count++;
    }
    return count;
}

string[] words = {"asrg", "kdfjbv", "jbvpwie", "dpifjbv", "whb"};
Console.WriteLine(CountOfEven(words));