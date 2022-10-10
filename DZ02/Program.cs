/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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
        else
        {
            break;
        }
    }
    return result;
}

int sumOfDigits(int userNumber)
{
    int result = 0;
    while (userNumber > 0)
    {
        result += userNumber % 10;
        userNumber /= 10;
    }
    return result;
}

int userNumber = getNumberFromUser("Введите число: ");
int result = sumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} = {result}");
