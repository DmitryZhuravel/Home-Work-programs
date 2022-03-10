// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число => ");                              
string B = Console.ReadLine();                            
int a = int.Parse(B);
if (a<=999&&a>=100) Console.WriteLine($"Вторая цифра трехзначного числа равна {a/10%10}");
else Console.WriteLine($"Введено не трехзначное число");
// Используя массив
Console.Write("Введите число => ");
string A = Console.ReadLine();
int[] arr = new int[A.Length];
for (int i = 0; i < A.Length; i++) arr[i] = Convert.ToInt32(A.Substring(i, 1));
if (arr.Length < 2) Console.WriteLine("Второй цифры нет");
else Console.WriteLine($"Вторая цифра заданного числа => {arr[1]}");