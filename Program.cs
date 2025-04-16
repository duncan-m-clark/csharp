using System.IO;

public class Game {
    static void Main() {
        Console.WriteLine("Welcome to the Number Guessing Game!");

        string path = @"Scores\scores.txt";
        if (!File.Exists(path)) {
            using FileStream stream = File.Create(path);
            using StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Easy 0");
            writer.WriteLine("Medium 0 ");
            writer.WriteLine("Hard 0");
        }

        FileStream editStream = File.Open(path, FileMode.Open, FileAccess.ReadWrite);

        bool quit = false;
        while (!quit) {
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("\nSelect your difficulty level:");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)\n");
            Console.Write("Enter your choice: ");
            
            int option = Convert.ToInt32(Console.ReadLine());
            int target = new Random().Next(1, 101);
            string difficulty = "";
            int tries = 0;

            switch (option) {
                case 1:
                    difficulty = "Easy";
                    tries = 10;
                    break;
                case 2:
                    difficulty = "Medium";
                    tries = 5;
                    break;
                case 3:
                    difficulty = "Hard";
                    tries = 3;
                    break;
            }

            Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
            Console.WriteLine("Let's start the game!\n");
            bool guessedIt = false;

            for (int i = 0; i < tries; i++) {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < target) {
                    Console.WriteLine($"Incorrect! The number is greater than {guess}.\n");
                } else if (guess > target) {
                    Console.WriteLine($"Incorrect! The number is less than {guess}.\n");
                } else {
                    Console.WriteLine($"Congratulations! You guessed the corect number in {i+1} attempts.");
                    guessedIt = true;
                    break;
                }
            }

            if (!guessedIt) {
                Console.WriteLine("Oh no! You've failed to guess the number.");
            }

            Console.Write("Would you like to play again? (Y/N) ");
            char cont = Convert.ToChar(Console.ReadLine());

            if (cont.Equals('N')) {
                Console.WriteLine("Thanks for playing!");
                quit = true;
            }

        }
    }
}