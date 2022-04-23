int ShowNumber(int n)
{
    
    int firstNum = n / 10;
    int secondNum = n % 10;

    Console.Write(n + " -->  ");

    if(firstNum > secondNum)
        {
            return firstNum;
        }
    else
        {
            return secondNum;
        }
}

int num = new Random().Next(10, 99);
int a = ShowNumber(num);
Console.WriteLine(a);