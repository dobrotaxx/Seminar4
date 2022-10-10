/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

void printInConsoleWithColor(string information, ConsoleColor color) /* Метод окрашивает текст: string information - сюда будем вводить 
текст, ConsoleColor color - а сюда цвет, например: ConsoleColor.DarkRed
printInConsoleWithColor($"Верхняя граница отрицательна{endPoint}", ConsoleColor.DarkRed); - полноценный пример*/
{
    Console.ForegroundColor = color; // Задем цвет
    Console.WriteLine(information); // команда с переменной information, в которой хранится окрашиваемый текст
    Console.ResetColor();//Команда, которая возвращает цвет по умолчанию для всего остального текста
}

int getSumOfRange(int startPoint, int endPoint)/*Метод находит сумму ряда. 
int startPoint - стартовая точка (поставим 1)
int endPoint - конечная точка, которую задаст пользователь*/
{
    int result = 0;
    if (startPoint > endPoint)/*Проверка числа на отрицательность. Если startPoint больше, чем endPoint, то будет замена значений в 
    переменных*/
    {
        printInConsoleWithColor($"Верхняя граница отрицательна: [{endPoint}]", ConsoleColor.DarkRed);
        int buff = startPoint; //Замена значений в переменных(меняем местами startPoint и endPoint, чтобы метод выдал сумму ряда от отрицательного числа до 1.)
        startPoint = endPoint; //Замена значений в переменных(меняем местами startPoint и endPoint, чтобы метод выдал сумму ряда от отрицательного числа до 1.)
        endPoint = buff; //Замена значений в переменных(меняем местами startPoint и endPoint, чтобы метод выдал сумму ряда от отрицательного числа до 1.)
    }
    else printInConsoleWithColor($"Верхняя граница положительна: [{endPoint}]", ConsoleColor.DarkGreen);
    for (int i = startPoint; i <= endPoint; i++)//Основной цикл, который будет суммировать ряд чисел
    {
        result += i; // += значит, что к result будет прибавляться значение i
    }
    return result;
}

printInConsoleWithColor("Введите верхнюю границу для суммы ряда: ", ConsoleColor.White);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRange = getSumOfRange(1, userNumber);
if (userNumber < 0) Console.WriteLine($"Сумма чисел от {userNumber} до 1 = {sumOfRange}");
else Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRange}");
