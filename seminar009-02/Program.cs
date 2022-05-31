// a^b = x

Console.Clear();
int Exponentiation(int a, int b)
{
    if (b > 0)
    {
        return a * Exponentiation(a, b-1);
    }
    else    
        return 1;
}

Console.WriteLine(Exponentiation(5,3));

// Работает только для положительных степеней