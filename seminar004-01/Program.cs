//

int NaturalSum(int a)
{
    int sum = 0;

    if (a < 1) return 0;

    else
    {
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i;
            // sum += i;
        }
        return sum;
    }  
}

Console.WriteLine("Input your number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements is " + NaturalSum(usernum));