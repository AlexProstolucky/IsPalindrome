
internal class Program
{
    public static bool IsPalindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Write text to check it:");
        string text; 
        text = Console.ReadLine();
        bool Palindrom = IsPalindrome(text);
        Console.WriteLine(Palindrom);
        Console.ReadKey();
    }
}