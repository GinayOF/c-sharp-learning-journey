/* Drawing an empty square
This code was written on the fourth day of learning C#.
*/

int i = 0;
int j = 0;
int size = 0;

do
{
    Console.WriteLine("Enter the size of the square: ");
} while (!(int.TryParse(Console.ReadLine(), out size)));

for (i = 1; i <= size; i++)
{
    for (j = 1; j <= size; j++)
    {
        if (i == 1 || j == 1 || i == size || j == size)
            Console.Write("# ");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}


