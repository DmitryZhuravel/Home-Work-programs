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
    if (b == e && c == d) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
else Console.WriteLine("Вы ввели не пятизначное число!!!");
// Решение через массив
Console.Write("Введите число => ");
string A = Console.ReadLine();
int[] arr = new int[A.Length];
for (int i = 0; i < A.Length; i++) arr[i] = Convert.ToInt32(A.Substring(i, 1));
if (arr.Length>=5)
{
    if (arr[0]==arr[4]&&arr[1]==arr[3]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}    
else Console.WriteLine("Вы ввели не пятизначное число!!!");