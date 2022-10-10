/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= userNumber; i++)
{
    result = result * i;
}
Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {result}");
