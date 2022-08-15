//Принцип решения с for.
/*int A = Convert.ToInt32(Console.ReadLine());
int sum =0;
for(int i = 1; i <= A; i++)
{
    sum += i;
}
Console.Write($"Cevvf {A} = {sum}");*/


//Принцип решения с while.
/*int A = Convert.ToInt32(Console.ReadLine());
int GetSumNumbers(int number)
{
    int sum =0;
    int start = 1;
    while(start <= number)
    {
        sum += start;
        start++;

    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");*/
//ToString().Length

/*Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = N.ToString().Length;
Console.WriteLine(sum);*/


/*int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers (int number)
{
    int count = 0;
    while (number >0)
    {
        count++;
        number /= 10;  
    } 
    return count;
}
Console.WriteLine($"{GetCountNumbers(num)}");*/



/*Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetMultipley(int number)
{
    int result = 1;
    for(int i =1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"{GetMultipley(num)}");*/


/*int[] GetBinaryArray (int size)
{
    int[] result = new int[size];
for (int i =0; i < result.Length; i++)
{
    result[i] = new Random().Next(2);
}
return result;
}
int[] testArray = GetBinaryArray(8);
Console.WriteLine($"Массив: [{String.Join(";",testArray)}]"); //Перевод массива в строчку.*/