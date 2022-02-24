using Assign_Question2_Practice;
using System.Text;

public class Program
{
    public static void Main()
    {
        string fiveWordStr = "one two three four five";
        StringBuilder sb = new StringBuilder(fiveWordStr);

        Console.WriteLine($"Num of words for string: \"{fiveWordStr}\" is ==> {sb.GetWordCount()}");

    }
}