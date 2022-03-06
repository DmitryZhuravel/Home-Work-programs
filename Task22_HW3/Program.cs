// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int a=Prompt("Введите пятизначное число =>  ");
if (a > 9999 && a < 100000)
{
   int b=a/10000; 
   int c=a%10000/1000; 
   int d=a/10%10; 
   int e=a%10; 
   if (b == e && c == d) Console.Write("Это число палиндром");
   else Console.Write("Это число не палиндром");
}
else Console.Write("Вы ввели не пятизначное число!!!");
