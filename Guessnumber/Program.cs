
using System.ComponentModel.Design;
using System.Threading.Channels;

Random random = new Random();
int randomNumber = random.Next(1, 101);

int maxAttempts = 10;
int attempts = 0;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------------------------------------");
Console.WriteLine("Welcome to the Guess the number game   ");
Console.WriteLine("---------------------------------------");
Console.ResetColor();
while (attempts < maxAttempts)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();


    if (int.TryParse(input, out int guess))
    {
        attempts++;

        if (guess == randomNumber)
        {
            Console.WriteLine($"Congrulations! your guess {randomNumber} was correct! in {attempts} attempts ");
            break;
        }
        string hint;
        if (guess < randomNumber)
        {
            hint = "too low";
        }
        else
        {
            hint = "too high";
        }
        Console.WriteLine($"Incorrect! your guess is {hint}. try again.");
    }
    else
    {
        Console.WriteLine("Invalid input.. Please enter valid number. ");
    }

    if (attempts >= maxAttempts)
    {
        Console.WriteLine($"sorry, u couldnt guess ur number {randomNumber} withing {maxAttempts} attempts ");

    }

}

     
