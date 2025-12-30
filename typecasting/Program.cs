// typecasting 
// implicit and explicit conversions

//implicit conversion example

int bigNumber = 123456;
long biggerNumber = bigNumber; // implicit conversion from int to long

Console.WriteLine($"Implicit Conversion: int {bigNumber} to long {biggerNumber}");

//explicit conversion example

double decimalNumber = 123.45;
int wholeNumber = (int)decimalNumber; // explicit conversion from double to int

Console.WriteLine($"Explicit Conversion: double {decimalNumber} to int {wholeNumber}");