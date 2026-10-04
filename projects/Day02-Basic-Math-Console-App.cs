/* Two-Number Basic Math Console App
This code was written on the second day of learning C#.
*/

double _result = 0;
double _number1 = 0;
double _number2 = 0;
string _operator;

Console.Write("Enter first number: ");
while ((double.TryParse(Console.ReadLine(), out _number1) == false))
{
    Console.WriteLine("Invalid input");
    Console.Write("Enter first number: ");
}

Console.Write("Choose an Operator (+,-,*,/): ");
_operator = Console.ReadLine();
while (_operator != "+" && _operator != "-" && _operator != "*" && _operator != "/")
{
    Console.WriteLine("Invalid input");
    Console.Write("Choose an Operator (+,-,*,/): ");
    _operator = Console.ReadLine();
}

Console.Write("Enter second number: ");
while ((double.TryParse(Console.ReadLine(), out _number2) == false))
{
    Console.WriteLine("Invalid input");
    Console.Write("Enter second number: ");
}

if (_operator == "/" && _number2 == 0)
{
    Console.WriteLine("Division by zero is not allowed");
    return;
}

if (_operator == "+")
    _result = _number1 + _number2;
else if (_operator == "-")
    _result = _number1 - _number2;
else if (_operator == "*")
    _result = _number1 * _number2;
else
_result = _number1 / _number2;

Console.WriteLine($"Result: {_result}");



