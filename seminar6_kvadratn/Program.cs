// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1 4 9 16 25
// 2 -> 1 4 

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"{N} -> ");
while (i <= N){
    Console.Write($" {Math.Pow(i,2)}");
    if (i != N){
        Console.Write(", ");
    }
    i++;
}
// int i = 1 ;
//string s = (i * i).Tostring() + (i != N ? ", " : "");

