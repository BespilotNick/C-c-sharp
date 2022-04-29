// List of squares of digits in range from 1 to N

void ListOfSquares(int N)
{
    int num = 1;

    while(num <= N)
    {
        int result = num*num;
        num++;
        Console.Write(result + " ");
    }
}

Console.WriteLine("Input a number");
int usernum = Convert.ToInt32(Console.ReadLine());

ListOfSquares(usernum);