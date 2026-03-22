namespace taskAOTConsole;
class Program
{


    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Загадайте число від 0 до 100");
            int low = 0;
            int high = 100;
            string response;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                Imports.MessageBox(IntPtr.Zero,
                    $"Your number {mid}?\nYes - yes\nNo - more\nCancel - less",
                    "Guess the number",
                    3);

                Console.Write("Enter your response (yes/more/less): ");
                response = Console.ReadLine();

                if (response == "yes")
                {
                    Imports.MessageBox(IntPtr.Zero, "I guessed it!", "Result", 0);
                    break;
                }
                else if (response == "more")
                {
                    low = mid + 1;
                }
                else if (response == "less")
                {
                    high = mid - 1;
                }
            }
            Console.Write("Play again? (y/n): ");
            playAgain = Console.ReadLine() == "y";
        }
    }
}