double x = 8.2;
double a = 2.2;
double b = 8.2;
double y = (Math.Exp(x-2.7)+3)/(x+1.3);
double z = (y + 0.75 * Math.Abs(Math.Cos(b) + a))/(Math.Pow(y,2)+0.75 * Math.Abs(Math.Cos(b)));
Console.WriteLine(z);
Console.WriteLine(y);
