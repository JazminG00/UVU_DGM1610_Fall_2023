namespace lol 
{
    class program
    {
        static void Main(string[] args)
        {
            {
    Random random = new Random;
    bool startAgain = true;
    int min = 1;
    int max = 10;
    int guess;
    int number;
    int guesses;
    string response;

    while (playAgain)
    {
        guess = 0;
        guesses = 0;
        response = "";
        number = random.Next(min, max + );

        while (guess != number)
        {
            Console.WriteLine(guess as number between " + min + " - " : ");
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Guess;" + guess);

            if (guess > number)
            {
                Console.WriteLine(guess + " is to high!)";)
            }
            else if (guess < number)
            {
                Console.WriteLine(guess + " is to low!");
            }
            guesses++; 
        }
        ConsoleWriteLine("Number; " + number);
        Console.WriteLine("WINNER!");
        Console.WriteLine("Guesses: " + guesses);

        ConsoleWriteLine("Wanna Play Again? (Y/N): ");
        response = Console.ReadLine();
        response = response.ToUpper();

        if (response == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
        }
    }
    Console.WriteLine("Thanks!");

    Console.ReadKey();
    }


        }
    }
}
