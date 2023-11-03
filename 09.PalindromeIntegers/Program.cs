/*
123
323
421
121
END
*/
internal class Program
{
    static void Main()
    {

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            bool isNumberPalindrome = IsPalindrom(input);
            Console.WriteLine(isNumberPalindrome);
        }

    }

    private static bool IsPalindrom(string symbols)
    {
        int leftIndex = 0;
        int rightIndex = symbols.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (symbols[leftIndex] != symbols[rightIndex])
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }
}