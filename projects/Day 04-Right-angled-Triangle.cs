/* Drawing a right-angled triangle
This code was written on the fourth day of learning C#.
*/


int rows = 0;
int i = 0;
int j = 0;

do
{
    Console.WriteLine("Enter the number of rows: ");

} while (!(int.TryParse(Console.ReadLine(), out rows)));


for (i=1; i <= rows; i++)
{
    for (j =  1; j <= i; j++)
        {
        Console.Write("#");
        }
    Console.WriteLine();

}
