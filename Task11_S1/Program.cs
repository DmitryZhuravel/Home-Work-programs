// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int a=Prompt("Введите число a =>  ");
int b=Prompt("Введите число b =>  ");
if (a>b)
{
    if (a%b==0) Console.WriteLine($"Число {a} кратно числу {b}");
    else Console.WriteLine($"Число {a} не кратно числу {b}, остаток {a%b}");
}
else 
{
    if (b%a==0) Console.WriteLine($"Число {b} кратно числу {a}");
    else Console.WriteLine($"Число {b} не кратно числу {a}, остаток {b%a}");
}
Console.WriteLine ("Введите первое число: ");
string inputA = Console.ReadLine ();
int A = int.Parse (inputA);
Console.WriteLine ("Введите второе число: ");
string inputB = Console.ReadLine ();
int B = int.Parse (inputB);

if (B%A == 0) Console.WriteLine($"Число {B} кратно числу {A}");
else Console.WriteLine($"Остаток от деления {B%A}"); 