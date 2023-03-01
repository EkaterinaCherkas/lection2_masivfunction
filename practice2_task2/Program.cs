// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456= 46 918=98
Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num / 10;
int a3 = num % 10;
Console.WriteLine($"{num} -> {a1}{a3}");

//two another methods
//Console.Clear();
//int num = new Random().Next(100, 1000);
//int result = (num / 100) * 10 + num % 10;
//Console.WriteLine($"{num} -> {result}");
//Console.WriteLine($"{num} -> {num / 100}{num % 10}");