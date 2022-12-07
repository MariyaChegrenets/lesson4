// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());
int Proizved (int number)
{
    int proizved = 1;
    while(number != 1)
    {
        proizved = proizved * number;
        number --; // шаг -1
    }
    return proizved;
}
Console.WriteLine(Proizved(number));