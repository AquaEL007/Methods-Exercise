namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            SwipePlaces(ref first, ref second);

            PrintCharsInRange(first, second);
        }

        private static void SwipePlaces(ref char first, ref char second)
        {
            if ((char)first > (char)second)
            {
                char temp = first;
                first = second;
                second = temp;
            }
        }

        private static void PrintCharsInRange(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                char character = (char)i;
                Console.Write($"{character} ");
            }
        }
    }
}