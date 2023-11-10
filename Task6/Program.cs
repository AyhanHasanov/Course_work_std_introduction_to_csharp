//412
//Да се направят два метода за 
//  1. въвеждане на целочислен едномерен масив
//  2. за изчисляване на броя на елементите от масива с нечетен индекс и които се делят на 5 без остатък
//В главния метод


//One way
//int[] InputArray()
//{
//    return Console.ReadLine()
//        .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
//        .Select(x => int.Parse(x))
//        .ToArray();
//}

int[] InputArray()
{
    string input = Console.ReadLine();
    string[] strArr = input.Split(' ');
    int[] res = new int[strArr.Select(x => int.Parse(x)).Count()];

    for (int i = 0; i < strArr.Length; i++)
    {
        Console.WriteLine("\tArray's lenght is: " + res.Length);
        Console.WriteLine($"\t{string.Join(' ', res)}");
        if (int.TryParse(strArr[i], out int num))
            res[i] = num;
        else
        {
            Console.WriteLine($"{strArr[i]} (index: {i}) is not an integer digit. It will be excluded from the array!");

            //res = res.Take(res.Length - 1).ToArray();
        }
    }

    return default;
}


int CountOfOddIndex(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
        if (arr[i] % 5 == 0)
            count++;

    return count;
}
/*Console.WriteLine(CountOfOddIndex(InputArray()));*/
Console.WriteLine(InputArray());