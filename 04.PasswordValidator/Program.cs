namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            char[] charArray = password.ToCharArray();

            int digitsCounter = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                char character = password[i];

                if (character > 47 && character < 58)
                {
                    digitsCounter++;
                }
            }
            for (int i = 0; i < charArray.Length; i++)
            {
                char character = password[i];
                if ((character < 48 || character > 57) && (character < 65 || character > 90) &&
                                (character < 97 || character > 122))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (digitsCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return;
            }

            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
