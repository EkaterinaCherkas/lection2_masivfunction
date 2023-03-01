// Напишите прорамму, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если второе число не кратно первому, то программа выводит остаток от деления.
// 34,5  не кратно (остаток от деления 4) 16,4 кратно

Console.Clear();
Console.WriteLine("Введите два числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 % number2 == 0){
    Console.Write("Второе число кратно первому");
}
else {
    int ost = number1 % number2;
    Console.Write("Не кратно, остаток " + ost);
    //Console.Write($"Не кратно, остаток {ost}");
}



