using AulaDelegate.Services;

double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.Sum;

double result = op(a, b);
Console.WriteLine(result);
