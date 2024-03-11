using System.Text;

namespace Palindromer
{
    class Program {
        static void Main(string[] args)
        {

            while (true)
            {
                bool isPalindrome = false;

                Console.WriteLine("Write a text, a number or a decimal number to check if it is a palindrome");
                string input = Console.ReadLine();

                string inputDatatype = GetInputDatatype(input);
                switch (inputDatatype)
                {
                    case "number":
                        isPalindrome = IsPalindrome(int.Parse(input));
                        break;

                    case "decimal number":
                        isPalindrome = IsPalindrome(decimal.Parse(input));
                        break;
                    case "text":
                        isPalindrome = IsPalindrome(input);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine(isPalindrome ? "It is a palindrome" : "It is not a palindrome");

                Console.WriteLine();
                Console.WriteLine("Do you want to check another one? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
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

        static bool IsPalindrome(int number)
        {
            for (int i = 0; i < number.ToString().Length / 2; i++)
            {
                if (number.ToString()[i] != number.ToString()[number.ToString().Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPalindrome(decimal number)
        {
            string numberString = RemoveSpecialCharacters(number.ToString());

            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - i - 1])
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

        static string GetInputDatatype(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return "number";
            }
            else if (decimal.TryParse(input, out decimal decimalNumber))
            {
                return "decimal number";
            }
            else
            {
                return "text";
            }
        }
    }
}
