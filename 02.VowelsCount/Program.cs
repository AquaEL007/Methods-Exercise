namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower(); //SoftUni

            char[] charArray = input.ToCharArray();

            int vowelsCounter = 0;
            vowelsCounter = VowelsCounter(input, charArray, vowelsCounter);
        }

        static int VowelsCounter(string input, char[] charArray, int vowelsCounter)
        {
            for (int i = 0; i < input.Length; i++)
            {
                //a, e, i, o, u, y
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                {
                    vowelsCounter++;
                }
                if (i == charArray.Length - 1)
                {
                    Console.WriteLine(vowelsCounter);
                }
            }

            return vowelsCounter;
        }
    }
}