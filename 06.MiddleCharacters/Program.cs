namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();

            if (charArray.Length % 2 != 0)
            {
                int position = charArray.Length / 2;
                Console.WriteLine(charArray[position]);
            }
            else
            {
                int evenPosition1 = charArray.Length / 2;
                Console.Write($"{charArray[evenPosition1-1]}{charArray[evenPosition1]}");
            }

        }
    }
}