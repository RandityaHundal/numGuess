# Number Guessing Game

This is a simple console application written in C# that generates a random number and prompts the user to guess it.

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in JetBrains Rider.
3. Run the program.

## Program Flow

1. The program will first generate a random number between 1 and 100.
2. It will then prompt you to guess the number.
3. If your guess is too high, it will prompt you to guess lower, and if your guess is too low, it will prompt you to guess higher.
4. The game continues until you guess the correct number.

## Code Snippet

```csharp
Random numGen = new Random();
int number = numGen.Next(0,101);

Console.WriteLine("input a number 1 - 100");
int guess = Convert.ToInt32(Console.ReadLine());

if (guess == number)
{

}
else
{
    while (guess != number)
    {
        string status = "tbd";
        if (guess > number)
        {
            status = "Lower, try again";
        }

        if (guess < number)
        {
            status = "Higher, try again";
        }

        Console.WriteLine(status);
        guess = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Congrats you guessed it!");

// close by key
Console.ReadKey();
