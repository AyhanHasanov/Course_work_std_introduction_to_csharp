//Зад. 53 от сборника на Крушков
//Напишете програма за изчисляване на фунцията sgn(x), като се изплозва условен оператор
// sgn(x) = -1, x < 0
// sgn(x) = 0, x = 0
// sgn(x) = 1, x > 0

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Въведете, което и да е, число: ");
double number = double.Parse(Console.ReadLine());

Console.WriteLine(Math.Sign(number));
