# Day 1
## What is C#
C# runs on the .NET platform
It is an object-oriented (OOP) language
It took its basic programming logic and syntax from C
It took its object-oriented programming logic from C++
It took its virtual machine, garbage collection, exception handling, and class-based design from Java
## Escape Characters

| Expression | Meaning         |
| ---------- | --------------- |
| `\n`       | New line        |
| `\r`       | Carriage return |
| `\t`       | Tab             |
| `\b`       | Backspace       |
| `\v`       | Vertical Tab    |
| `\"`       | Double quote    |
| `\'`       | Single quote    |
| `\\`       | Backslash       |
| `\0`       | null char       |
| `\u`       | Unicode4        |
| `\U`       | Unicode8        |
| `\x`       | UnicodeHex      |
## Comments
`//` - Single-line comment
`/* */`  - Block comment
## Variables

| **Type**    | **Bits**  | **Value Range**                            | **Description / Usage**           |
| ----------- | --------- | ------------------------------------------ | --------------------------------- |
| **bool**    | 8         | `true` / `false`                           | Logical value                     |
| **byte**    | 8         | $0 - 255$                                  | Small positive numbers            |
| **sbyte**   | 8         | $-128 - 127$                               | Small numbers                     |
| **short**   | 16        | $-32,768 - 32,767$                         | Small integer                     |
| **ushort**  | 16        | $0 - 65,535$                               | Positive integer                  |
| **int**     | 32        | $-2,147,483,648 - 2,147,483,647$           | Default integer                   |
| **uint**    | 32        | $0 - 4,294,967,295$                        | Positive integer                  |
| **long**    | 64        | $-9.2 \text{ quintillion} - 9.2 \text{ quintillion}$ | Very large number       |
| **ulong**   | 64        | $0 - 18.4 \text{ quintillion}$             | Very large positive number        |
| **float**   | 32        | $\pm 1.5\text{E}-45 - \pm 3.4\text{E}38$   | Floating-point (low precision)    |
| **double**  | 64        | $\pm 5.0\text{E}-324 - \pm 1.7\text{E}308$ | Floating-point (high precision)   |
| **decimal** | 128       | $\pm 1.0\text{E}-28 - \pm 7.9\text{E}28$   | Money / finance                   |
| **char**    | 16        | `'\u0000'` – `'\uFFFF'`                    | Single Unicode character          |
| **string**  | variable  |                                            | Text                              |
A float value must end with f
A decimal value must end with m
### Constant Variable
Variables whose values cannot be changed afterwards
When creating the variable, add const before the variable type
const float euler = 2.718f;
### Variable Names
A variable name cannot start with a number
A variable name cannot contain spaces or special characters like + - !
camelCase = the first word starts with a lowercase letter, the remaining words start with uppercase
snake_case = all words are lowercase, separated by underscores
PascalCase = all words start with an uppercase letter
_camelCase = starts with an underscore, the rest is camelCase
## Type Casting
### Implicit Type Conversion
Converting a smaller data type to a larger data type
Since there is no risk of data loss, it is done automatically
### Explicit Type Conversion
Converting a larger data type to a smaller data type
Since there is a risk of data loss, it is done manually

| Convert Method       | Target Data Type | Description                                   |
| :------------------- | :--------------- | :-------------------------------------------- |
| `Convert.ToInt16`    | `short`          | 16-bit signed integer                         |
| `Convert.ToInt32`    | `int`            | 32-bit signed integer                         |
| `Convert.ToInt64`    | `long`           | 64-bit signed integer                         |
| `Convert.ToDouble`   | `double`         | Floating-point number (64-bit)                |
| `Convert.ToSingle`   | `float`          | Floating-point number (32-bit)                |
| `Convert.ToDecimal`  | `decimal`        | Financial / high-precision floating-point number |
| `Convert.ToByte`     | `byte`           | 8-bit unsigned integer (0 - 255)              |
| `Convert.ToSByte`    | `sbyte`          | 8-bit signed integer (-128 - 127)             |
| `Convert.ToString`   | `string`         | Text                                          |
| `Convert.ToBoolean`  | `bool`           | Logical value (true/false)                    |
| `Convert.ToChar`     | `char`           | Single Unicode character                      |
| `Convert.ToDateTime` | `DateTime`       | Date and time value                           |
``` C#
double a = 7.41;
int b = (int)a;  // No rounding is performed

int c = Convert.ToInt32(Console.ReadLine());  // Rounding is performed (Banker's rounding = rounding to the nearest even number. If the value is .5, it is rounded to the nearest even number; otherwise it is rounded to the nearest number)
int d = int.Parse(Console.ReadLine());

int e = 5;  
string eText  = e.ToString();
```

# Day 2
## Nullable Type
### Value type 
The variable stores the data itself directly inside it (in the stack region) (this only applies to local variables and method parameters; if it is defined as a field inside a class or object, it is stored in the Heap region.)
Copy behavior: When a variable is assigned to another variable, the value is copied 
The two variables are completely independent; a change in one does not affect the other

In C#, value types like int, bool, double cannot be null
int x = null; does not work
double y = null; does not work

If you want a value type to be nullable, you must put ? at the end of the variable type
int? x = null; works
double? x = null; works

#### Example 1
``` C#
int? x = null; // The variable x was created as nullable
int y = x?? 0; // The variable y is not nullable, so if we tried to simply set it equal to x we would get an error, but thanks to the x?? structure, if the value of x is null, y is automatically set to 0. Instead of 0 we could also write any integer we want.
int z = x.GetValueOrDefault();
// In the usage above, if x is null, z is set to 0.
```
#### Example 2 
``` C#
int x = 7;  
int? y = null;  
int? z = x + y;  
int a = x + (y ?? 0);
Console.WriteLine(z); // The result of this is null because integer + null = null
Console.WriteLine(a); // The result of this is 7 because when y is null it is automatically treated as 0.
``` 
### Reference type 
The variable itself stays on the stack, but it holds the address of the data in memory 
The actual data is stored in a memory region called the heap
Copy behavior: When a variable is assigned to another variable, the value is not copied; the address (reference) in the heap is copied 
Both variables point to the same object in the heap; a change made in one also affects the other (string is not included in this behavior)
# Operators 
## Arithmetic
`+ - * / % ++ --`

``` C#
int x = 7;
int y = x++;
Console.WriteLine(y); // Output 7
Console.WriteLine(x); // Output 8
Console.WriteLine(y++); // Output 7
Console.WriteLine(y); // Output 8
```
## Assignment
### Normal
`== += -= *= /= %= `
### Bitwise 
`^= &= |= <<= >>=`
## Comparison
`== != > < >= <= `
## Logical
`&& || !`
Order of precedence 
1) ! 
2) && 
3) ||

# Conditions
if,
else,
else if,
switch
## Ternary
(condition) ? expressionTrue : expressionFalse;
``` C#
int age = 28;
string result = (age >= 18) ? "Adult":"Underage";
```
