// Задача 122.ж) от сборника на Крушков

//x е някакво число по-малко от 1, защото няма arccos(x) за х > 1
//eps указва до кой знак след запетаята да се изчислява с точност

Console.OutputEncoding = System.Text.Encoding.UTF8;

double x = 0.0;
double eps = 0.0;

Input(ref x, ref eps);

double solvedX = SolveForX(x, eps);

Console.WriteLine($"f(x) = {solvedX}");
Console.WriteLine($"arccos(x) = {Math.Acos(x)}");
Console.WriteLine($"f(x) == arrcos(x) : {solvedX == Math.Acos(x)}");

double SolveForX(double x, double eps)
{
    double result = Math.PI / 2 - x;
    int i = 1;
    double term;

    do
    {
        //числител
        double numerator = 1.0;
        //знаменател
        double denominator = 1.0;

        for (int j = 1; j <= i; j++)
        {
            numerator *= (2 * j - 1);
            denominator *= (2 * j);
        }

        term = (numerator / denominator) * (Math.Pow(x, 2 * i + 1)) / (2 * i + 1);
        result -= term;
        i++;
    }
    while (Math.Abs(term) >= eps); //ако текущия резултат от пресмятането стане по-малко от зададената точност, прекъсни програмата

    return result;
}

void Input(ref double x, ref double eps)
{
    do
    {
        Console.Write("Въведете число, което е между 0 и 1: ");
        x = double.Parse(Console.ReadLine());
    } while (Math.Abs(x) >= 1);

    do
    {
        Console.Write("С точност до (трябва да е > 0 и < 0.01): ");
        eps = double.Parse(Console.ReadLine());
    } while (eps <= 0 || eps >= 0.01);
}
