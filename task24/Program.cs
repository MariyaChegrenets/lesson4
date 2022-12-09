// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number < 1)
// {
//     Console.WriteLine("Input incorrect");
// }
// else
// {
// int sum = 0;
// for (int i=1; i<=number; i++)
// {
//     sum += i;
// }
// Console.WriteLine("Result is {0}", sum);
// }

Console.WriteLine(Result(number));
int Result(int number)
{
    int sum = 0;
    for (int i=1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
