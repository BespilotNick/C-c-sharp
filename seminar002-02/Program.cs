// The programm that delites the second digit in three-digit number

int EraserOfSecNum(int a)
{
    int firstNum = a / 100;
    int thirdNum = a % 10;
    
    int result = firstNum * 10 + thirdNum;

    return result;
}

Console.WriteLine("Input three-digit number:  ");
int tdnum = Convert.ToInt32(Console.ReadLine());
int x = EraserOfSecNum(tdnum);
Console.WriteLine(x);