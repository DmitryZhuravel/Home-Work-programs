﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
////int Prompt(string message)
//{
 //   Console.Write(message);
 //   string strInput=Console.ReadLine();
 //   int answer=int.Parse(strInput);
 //   return answer;
//}
//int a=Prompt("Введите пятизначное число =>  ");
//if (a > 9999 && a < 100000)
//{
//    int b=a/10000; 
//    int c=a%10000/1000; 
///    int d=a/10%10; 
 //   int e=a%10; 
 //   if (b == e && c == d) Console.WriteLine("Это число палиндром");
 //   else Console.WriteLine("Это число не палиндром");
//}
//else Console.WriteLine("Вы ввели не пятизначное число!!!");
// Решение через массив
Console.Write("Введите число => ");
string A = Console.ReadLine();
int[] arr = new int[A.Length];
for (int i = 0; i < A.Length; i++) arr[i] = Convert.ToInt32(A.Substring(i, 1));
if (arr.Length==1) Console.WriteLine("Это число палиндром");
if (arr.Length==2) 
{
    if (arr[0]==arr[1]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==3) 
{
    if (arr[0]==arr[2]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==4) 
{
    if (arr[0]==arr[3]&&arr[1]==arr[2]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==5) 
{
    if (arr[0]==arr[4]&&arr[1]==arr[3]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==6) 
{
    if (arr[0]==arr[5]&&arr[1]==arr[4]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==7) 
{
    if (arr[0]==arr[6]&&arr[1]==arr[5]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}    
if (arr.Length==8)
{
    if (arr[0]==arr[7]&&arr[1]==arr[6]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==9) 
{
    if (arr[0]==arr[8]&&arr[1]==arr[7]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==10) 
{
    if (arr[0]==arr[9]&&arr[1]==arr[8]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}