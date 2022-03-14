// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Решение через реверс
Console.Write("Введите число => ");                              
string B = Console.ReadLine();                            
int a = int.Parse(B);
string s = a.ToString();
int S = int.Parse(s);
char[] ar = s.ToCharArray();
Array.Reverse(ar);
s = new String(ar);
a = Convert.ToInt32(s);
if (a==S) Console.WriteLine($"Число {a} является полиндром");
else Console.WriteLine($"Число {B} не является полиндромом, после разворота оно равно {s}");



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
    if (arr[0]==arr[5]&&arr[1]==arr[4]&&arr[2]==arr[3]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==7) 
{
    if (arr[0]==arr[6]&&arr[1]==arr[5]&&arr[2]==arr[4]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}    
if (arr.Length==8)
{
    if (arr[0]==arr[7]&&arr[1]==arr[6]&&arr[2]==arr[5]&&arr[3]==arr[4]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==9) 
{
    if (arr[0]==arr[8]&&arr[1]==arr[7]&&arr[2]==arr[6]&&arr[3]==arr[5]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}
if (arr.Length==10) 
{
    if (arr[0]==arr[9]&&arr[1]==arr[8]&&arr[2]==arr[7]&&arr[3]==arr[6]) Console.WriteLine("Это число палиндром");
    else Console.WriteLine("Это число не палиндром");
}