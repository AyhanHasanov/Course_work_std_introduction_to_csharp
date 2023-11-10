//Задача.353 от сборника на Крушков

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Въведете х: ");
bool isNum1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Въведете у: ");
bool isNum2 = int.TryParse(Console.ReadLine(), out int n);

if (isNum1 && isNum2)
    Console.WriteLine("Случайно генерирано число в интервала [{0}, {1}]: {2}", m, n, Read(m, n));
else
    Console.WriteLine("Въведените числа трябва да са цели!");

int Read(int x, int y)
{
    Random rndm = new Random();
    return rndm.Next(x, y + 1); // => [x,y]
}