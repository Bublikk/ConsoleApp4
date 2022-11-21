double x0 = Convert.ToDouble((string)Console.ReadLine());
double e = Convert.ToDouble((string)Console.ReadLine());
double x1, x;
double Sum(double x) => Math.PI-Math.Asin((1.0 / 2.0) * Math.Atan(x));
x1 = Sum(x0);


while (Math.Abs(x1) - Math.Abs(x0) > e)
{
    x0 = x1;
    x1 = Sum(x0);
}

x = x1;
Console.WriteLine(x);