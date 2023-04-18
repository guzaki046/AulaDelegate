using AulaDelegate.Services;

double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.Square;

double result = op(b);
Console.WriteLine(result);
