using AulaDelegate.Services;

double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;

op.Invoke(a, b);
