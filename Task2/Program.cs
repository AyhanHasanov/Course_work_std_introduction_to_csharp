//Зад. 12 от сборника на Крушков
//Да се напише програма, която въвежда положително седемцифрено число и извежда неговата 4та цифра. 
//xxxTxxx

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Въведете седемцифрено число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num > 9999999 || num < 1000000 ? "Не е седемцифрено число!" : num.ToString()[3]);