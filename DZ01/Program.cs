/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Ошибка ввода! Введите целое число: [{userLine}].");
        }
        else // Чтобы можно было вводить значение равное 0
        {
            break;
        }
    }
    return result;
}

int firstNum = getNumberFromUser("Введите число А: ");
int secondNum = getNumberFromUser("Введите натуральное число B: ");
int result = firstNum;
for (int i = 1; i < secondNum; i++)
{
    result = result * firstNum;
}
Console.Write($"Число {firstNum} в натуральной степени {secondNum} = {result}");
