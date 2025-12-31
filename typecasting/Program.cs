// typecasting 
// implicit and explicit conversions

//implicit conversion example

// int bigNumber = 123456;
// long biggerNumber = bigNumber; // implicit conversion from int to long

// Console.WriteLine($"Implicit Conversion: int {bigNumber} to long {biggerNumber}");

// //explicit conversion example

// double decimalNumber = 123.45;
// int wholeNumber = (int)decimalNumber; // explicit conversion from double to int

// Console.WriteLine($"Explicit Conversion: double {decimalNumber} to int {wholeNumber}");
 
// advanced type casting

// string to int
string numberString = "123456";
int result = 0;
if (int.TryParse(numberString, out result))
{
    Console.WriteLine($"String to Int Conversion: string '{numberString}' to int {result}");
}
else
{
    Console.WriteLine($"Conversion failed for string '{numberString}'");
}