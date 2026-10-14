/*
Number guessing app
This code was written on the fifth day of learning C#.
*/

int hp = 100;
int numberOfGuesses = 0;
int guess = 0;

Random rndm = new Random();
int number = rndm.Next(1, 101);

while (!(number == guess) && (hp>0))
{
    Console.WriteLine($"HP: {hp}");
    Console.WriteLine($"Number of Guesses: {numberOfGuesses}");
    numberOfGuesses++;
    hp -= 10;
    if (guess < number)
        {
            Console.WriteLine("Higher");
            do
            { Console.Write("Enter a number between 1 and 100: ");
            } while ((!(int.TryParse(Console.ReadLine(), out guess))) || (guess > 100) || (guess < 1));
        }
    else if (guess > number)
        {
            Console.WriteLine("Lower");
            do
            { Console.Write("Enter a number between 1 and 100: ");
            } while ((!(int.TryParse(Console.ReadLine(), out guess))) || (guess > 100) || (guess < 1));
        }
    Console.WriteLine($"--------------------------");

}

if (guess == number)
    Console.WriteLine("You won!");
else
{
    Console.WriteLine("Game over!");
    Console.WriteLine($"The number was {number}");
}
