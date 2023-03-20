using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        
        int countAbc = CountOccurrences(str1, "abc");
        string replacedStr1 = ReplaceAll(str1, "abc", "**");
        Console.WriteLine($"Occurrences of 'abc': {countAbc}");
        Console.WriteLine($"Replaced string: {replacedStr1}");


        int countWords = CountDoubleLetters(str2); 
        Console.WriteLine($"Count Double Letters: {countWords}");

        CompareStrings(str1, str2);
        ConcatenateStrings(str1, str2);

        
    }

    static int CountOccurrences(string input, string pattern)
    {
        int count = 0;
        int i = 0;
        while ((i = input.IndexOf(pattern, i)) != -1)
        {
            count++;
            i += pattern.Length;
        }
        return count;
    }

    static string ReplaceAll(string input, string pattern, string replacement)
    {
        return input.Replace(pattern, replacement);
    }
    static int CountDoubleLetters(string input)
    {
        int count = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                count++;
            }
        }
        return count;
    }


    static void CompareStrings(string str1, string str2)
    {
        Console.WriteLine($"\nString comparison between '{str1}' and '{str2}':");
        Console.WriteLine("Compare(string, string): " + string.Compare(str1, str2));
        Console.WriteLine("Equals(object): " + str1.Equals((object)str2));
        Console.WriteLine("== operator: " + (str1 == str2));

    }

    static void ConcatenateStrings(string str1, string str2)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append(str1); sb.Append(' '); sb.Append(str2);
        string sbConcat = sb.ToString();
        Console.WriteLine($"\nStringBuilder concatenation: {sbConcat}");

        string concat1 = str1 + " " + str2;
        string concat2 = string.Concat(str1, " ", str2);
        Console.WriteLine($"Operator +: {concat1}");
        Console.WriteLine($"Concat method: {concat2}");

    }
}