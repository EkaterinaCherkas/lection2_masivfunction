// Напишите программу, которая выводит случайное трёхзначное число и показывает вторую цифру этого числа. 456= 5 918=1 782=8
//Версия решения задачи из домашки с методами
Console.Clear();

int Prompt(string message){
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;}
int number = Prompt("Введите трёхзначное число > ");
if(number < 100 || number >= 1000){
    Console.WriteLine("Вы ввели не трёхзначное число,пожалуйста повторите ввод");
    return;}
Console.WriteLine($"Введенное число {number} ");
int seconddigit = number / 10 % 10;
Console.WriteLine($"Вторая цифра {seconddigit} ");

