/*
Prime Number Check
This code was written on the fifth day of learning C#.
*/

int number;
bool isPrime = true;
do
{ Console.Write("Enter a number: ");
} while ((!(int.TryParse(Console.ReadLine(), out number))));

for (int divide = 2; divide <= Math.Sqrt(number); divide++)
{
    if (number % divide == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime && number >= 2)
    Console.WriteLine($"{number} is a prime number");
else
    Console.WriteLine($"{number} is not a prime number");