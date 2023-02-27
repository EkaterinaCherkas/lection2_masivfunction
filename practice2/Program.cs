//Напишите программу ,которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа 
Console.Clear();

int num = new Random().Next(10, 100); // num = 16
int a1 = num / 10 ; // 16 / 10 = 1
int a2 = num % 10; // 16 % 10 = 6
int max = a1;
if (max < a2){
    max = a2;
}
Console.WriteLine($"Max digit of the number {num} -> {max}");

