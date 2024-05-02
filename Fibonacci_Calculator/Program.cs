using System;

public class Fibonacci
{
    private static int[] dp = new int[10010];

    static void Main(string[] args)
    {
        Console.WriteLine("This Program is for generating Fibonacci Number");

        // Initialize dp array with -1 (equivalent to unfilled in C#)
        Array.Fill(dp, -1);

        // Calculate and print Fibonacci number at position 4
        int fibonacciNumber = f(10);

        Console.WriteLine(fibonacciNumber);
    }

    private static int f(int n)
    {
        if (n == 0 || n == 1) return n;

        if (dp[n] != -1) return dp[n];

        dp[n] = f(n - 1) + f(n - 2);

        return dp[n];
    }
}
