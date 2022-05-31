// 

void NaturalNums(int n)
{
    if (n >= 1)
    {
        NaturalNums(n - 1);
        Console.Write(n + " ");
        
    }
}

//Console.WriteLine("input natural number: ");
//int usernum = Convert.ToInt32(Console.ReadLine());

NaturalNums(8);