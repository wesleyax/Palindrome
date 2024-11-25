namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word or number to check if it is a palindrome :");
            string value = Console.ReadLine();
            string palindrome = "";

            for (int i = value.Length - 1; i >= 0; i--) {
                palindrome += value[i];
            }
            if (palindrome.ToLower() == value.ToLower()) {
                Console.WriteLine(value + " is a Palindrome");
            } else {
                Console.WriteLine(value + " is not a Palindrome");
            }
            Console.ReadKey();
        }
    }
}
