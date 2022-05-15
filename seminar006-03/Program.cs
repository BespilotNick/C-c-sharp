﻿// Write a method that ask a user to input a number and ruteurn first usernum of Fibonacci (without recursion)

int[] SeqFibonacci(int a)
{
    int[] sequence = new int[a];
    sequence[0] = 0;
    sequence[1] = 1;

    for (int i = 2; i < a; i++)
        sequence[i] = sequence[i - 1] + sequence[i - 2];
    return sequence;
}

void ShowSeqFibonacci(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("How many digits of the Fibonacci sequence do you want to see?  ");
int usernum = Convert.ToInt32(Console.ReadLine());
ShowSeqFibonacci(SeqFibonacci(usernum));