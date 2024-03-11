using System.Text;

while (true) { 
    Console.WriteLine("Write a text, a number or a decimal number to check if it is a palindrome");
    string input = Console.ReadLine();

    bool isPalindrome = IsPalindrome(input);
    Console.WriteLine(isPalindrome ? "It is a palindrome" : "It is not a palindrome");

    Console.WriteLine();
    Console.WriteLine("Do you want to check another one? (y/n)");
    string answer = Console.ReadLine();
    if (answer.ToLower() != "y")
    {
        break;
    } else
    {
        Console.WriteLine();
    }
}

static bool IsPalindrome(string s)
{
    s = RemoveSpecialCharacters(s);
    s = s.ToLower();

    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

static string RemoveSpecialCharacters(string str)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < str.Length; i++)
    {
        if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
        {
            sb.Append(str[i]);
        }
    }
    return sb.ToString();
}