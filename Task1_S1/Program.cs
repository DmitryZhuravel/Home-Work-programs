﻿Console.Write("Введите число А => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A); 
Console.Write("Введите число B => ");                              
string B = Console.ReadLine();                            
int b = int.Parse(B); 
if (b==a*a)
{
    Console.WriteLine($"Число {b} является квадратом числа {a}");
}
else
{
    Console.WriteLine($"Число {b} не является квадратом числа {a}");
}