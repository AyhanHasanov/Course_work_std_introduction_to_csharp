//Задача 5.
//Задача 220.Г) от сборника на Крушков
//Задача 220.Д) от сборника на Крушков

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Резултати:\nГ): {0}\nД): {1}", CalculateProductG(), CalculateProductD());

double CalculateProduct(int limitNumerator, int limitDenomerator)
{
    //Продукт i=1, limit = limitNumerator (1/(i^3 + 1))
    //Разделено на
    //Продукт i=1, limit = limitDenumerator (1/(i + 1))
    //След преобразуване изразът е следния:
    //П(i=1, limitDenomerator) (i + 1) / П(i=1, limitNumerator) (i^3 + 1)

    double numerator = 1.0;
    for (int i = 1; i <= limitNumerator; i++)
        numerator *= (Math.Pow(i, 3) + 1);

    double denominator = 1.0;
    for (int i = 1; i <= limitDenomerator; i++)
        denominator *= (i + 1);

    return denominator / numerator;
}

double CalculateProductG()
{
    //По условие лимитът на числителя, знаменателя е 15
    return CalculateProduct(15, 15);
}

double CalculateProductD()
{
    //По условие лимитът на числителя е 15, знаменател - 20
    return CalculateProduct(15, 20);
}

