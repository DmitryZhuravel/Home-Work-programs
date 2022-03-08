// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
Random rnd=new Random();
int value=rnd.Next(10, 100);
Console.WriteLine($"Случайное трехзначное число {value}");
int a=value%10;
int b=value/10;
if (a>b) Console.WriteLine(a);
else Console.WriteLine(b);