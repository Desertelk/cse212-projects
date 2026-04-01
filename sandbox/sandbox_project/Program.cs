using System;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    static void Main(string[] args)
    { 
        // Console.WriteLine(reverse("tacocat"));
        // Console.WriteLine(isPalindrome("car"));
        // Console.WriteLine(SumOfDigits(456));
        // Console.WriteLine(MultiplyRecursion(3, 8));
        Console.WriteLine(CountChar("Penelope", 'e'));
    }

    static string reverse(string word)
    {
        if(word.Length <= 1)
        {
            return word;
        }

        char first = word[0];
        string rest = word.Substring(1);
        return reverse(rest) + first;
    }

    static bool isPalindrome(string word)
    {
        if (word.Length <= 1)
        {
            return true;
        }

        if (word.Length == 2)
        {
            return word[0] == word[1];
        }

        char first = word[0];
        char last = word[word.Length -1];

        if (first != last)
        {
            return false;
        }

        string middle = word.Substring(1, word.Length - 2);

        return isPalindrome(middle);
    }

    static int SumOfDigits(int n)
    {
        if (n == 0)
        {
            return n;
        }

        int lastDigit = n % 10;
        int rest = n / 10;

        int sum = lastDigit + SumOfDigits(rest);

        return sum;
    }

    static int MultiplyRecursion(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }

        int sum = a + MultiplyRecursion(a, b - 1);
        return sum;
    }

    static int CountChar (string text, char target)
    {
        if (text.Length == 0)
        {
            return 0;
        }

        char firstLetter = text[0];
        int counter = 0;
        string rest = text.Substring(0);

        if (target == firstLetter)
        {
            counter++;
        }
        CountChar(rest, target);
        return counter;
    }
}