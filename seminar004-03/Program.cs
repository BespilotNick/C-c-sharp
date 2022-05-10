// Factorial N


double Factorial(int N)
{
    if (N == 1 || N == 0) return 1;
    else return N * Factorial(N-1);
}

Console.WriteLine("input a number: ");
int usernum = Convert.ToInt32(Console.ReadLine());
if (usernum < 0)
    Console.WriteLine("to calculate the factorial of a given number, you will need to use the Euler gamma function");
else
    Console.WriteLine("Factorial of your number is: " + Factorial(usernum));