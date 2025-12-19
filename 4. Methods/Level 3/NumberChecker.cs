using System;

public static class NumberChecker
{
    
    public static int CountDigits(int n) => Math.Abs(n).ToString().Length;

    public static int[] GetDigits(int n)
    {
        n = Math.Abs(n);
        int[] d = new int[CountDigits(n)];
        for (int i = d.Length - 1; i >= 0; i--)
        {
            d[i] = n % 10;
            n /= 10;
        }
        return d;
    }

    
    public static bool IsDuck(int[] d)
    {
        foreach (int x in d) if (x != 0) return true;
        return false;
    }

    
    public static bool IsArmstrong(int n)
    {
        int[] d = GetDigits(n);
        int power = d.Length, sum = 0;
        foreach (int x in d) sum += (int)Math.Pow(x, power);
        return sum == n;
    }

    
    public static int[] LargestTwo(int[] d)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in d)
        {
            if (x > max1) { max2 = max1; max1 = x; }
            else if (x > max2 && x != max1) max2 = x;
        }
        return new int[] { max1, max2 };
    }

    public static int[] SmallestTwo(int[] d)
    {
        int min1 = int.MaxValue, min2 = int.MaxValue;
        foreach (int x in d)
        {
            if (x < min1) { min2 = min1; min1 = x; }
            else if (x < min2 && x != min1) min2 = x;
        }
        return new int[] { min1, min2 };
    }

    
    public static bool IsHarshad(int n)
    {
        int sum = 0;
        foreach (int x in GetDigits(n)) sum += x;
        return n % sum == 0;
    }

   
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    
    public static bool IsNeon(int n)
    {
        int sq = n * n, sum = 0;
        foreach (int x in GetDigits(sq)) sum += x;
        return sum == n;
    }

    
    public static bool IsSpy(int n)
    {
        int sum = 0, prod = 1;
        foreach (int x in GetDigits(n)) { sum += x; prod *= x; }
        return sum == prod;
    }

    public static bool IsBuzz(int n) => n % 7 == 0 || n % 10 == 7;
}
