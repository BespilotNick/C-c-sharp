//

string[] names = {"Nick", "Jessica", "Nikolai", "Alice", "Kate", "Alex", "Max", "John", "Anna"};

string[] SortedNames(string[] mass)
{
    for (int j = 0; j < mass.Length; j++)
    {
        for (int i = 0; i < mass.Length - 1; i++)
        {
            if (mass[i].Length > mass[i + 1].Length)
            {
                string temp = mass[i];
                mass[i] = mass[i + 1];
                mass[i + 1] = temp;
            }
            else if (mass[i].Length == mass[i + 1].Length)
            {
                for (int k = 0; k < mass[i].Length; k++)
                {
                    if (mass[i][k] > mass[i + 1][k])
                    {
                        string temp = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = temp;
                        break;
                    }
                    else if (mass[i][k] < mass[i + 1][k]) break;
                }
            }
        }
    }
    return mass;
}

void PrintSorted(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + "  ");
}

PrintSorted(SortedNames(names));