//412
//Условие 1:
//2 метода:
//    а) за въвеждане на целочислен едномерен масив
//    б) за изчисляване на броя на елементите от масива, които са с нечетен индекс и се делят на 5 без остатък
//Условие 2:
//    Да се въведе n - цяло число, и 3 едномерни целочислени масива - A[n], B[n], C[n]. За всеки масив да се изпълни и отпечата 1.б). Да се намери средногеометричното.
//Условие 3:
//Елементите на масива С да се преизчислят: 
//(a[n]-b[n])(a1-b1), (a[n-1]-b[n-1])(a2-b2), ... (a1-b1)(a[n]-b[n])

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("\nВъвеждане на масив А: " +
    "Въведете елементите на масива, като всеки елемент напишете на нов ред.");
int[] arrA = InputArray(n);

Console.WriteLine("\nВъвеждане на масив В: " +
    "Въведете елементите на масива, като всеки елемент напишете на нов ред.");
int[] arrB = InputArray(n);

Console.WriteLine("\nВъвеждане на масив С: " +
    "Въведете елементите на масива, като всеки елемент напишете на нов ред.");
int[] arrC = InputArray(n);

int countA = CountOfOddIndexAndDivideblesByFive(arrA);
int countB = CountOfOddIndexAndDivideblesByFive(arrB);
int countC = CountOfOddIndexAndDivideblesByFive(arrC);

Console.WriteLine("\nБрой на елементите, които са с нечетен индекс и се делят на 5 без остатък:\n" +
    "Масив A: {0}\n" +
    "Масив B: {1}\n" +
    "Масив C: {2}",
    countA, countB, countC);

//Средно геометрично N-ти корен от x1.x2.x3....xn
Console.WriteLine("\nСредногеометрична стойност на трите бройки: {0}", 
    Math.Cbrt(countA * countB * countC)); //Cbrt => Cube root корен 3-ти от 3те числа-бройки

Console.WriteLine("\nМасив C след преизчисляване: {0}", String.Join(" ", RecalculateArrayC(arrA, arrB)));

int[] InputArray(int limit)
{
    int[] result = new int[limit];

    for (int i = 0; i < limit; i++)
    {
        //Input next array element
        Console.Write($"[{i}]: ");
        bool isInteger = int.TryParse(Console.ReadLine(), out result[i]);
        if (!isInteger)
        {
            i--;
            Console.WriteLine("Въвеждайте само цели числа!");
        }
    }
    return result;
}

int CountOfOddIndexAndDivideblesByFive(int[] arr)
{
    int counter = 0;
    for (int i = 1; i < arr.Length; i += 2)
        if (arr[i] % 5 == 0)
            counter++;

    return counter;
}

int[] RecalculateArrayC(int[] arrA, int[] arrB)
{
    //(a[n]-b[n])(a1-b1), (a[n-1]-b[n-1])(a2-b2), ... (a1-b1)(a[n]-b[n])
    int length = arrA.Length;

    int controllerA = length - 1;
    int controllerB = 0;

    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        int temp = (arrA[controllerA] - arrB[controllerA]) * (arrA[controllerB] - arrB[controllerB]);
        res[i] = temp;
        controllerA--;
        controllerB++;
    }
    return res;
}