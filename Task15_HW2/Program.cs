// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Write("Введите число => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A);
if (a<=99) Console.WriteLine("Третьей цифры нет");
if (a>=100&&a<=999) Console.WriteLine($"Третья цифра равна {a%10}");
if (a>=1000&&a<=9999) Console.WriteLine($"Третья цифра равна {(a/10)%10}");
if (a>=10000&&a<=99999) Console.WriteLine($"Третья цифра равна {(a/100)%10}");
if (a>=100000&&a<=999999) Console.WriteLine($"Третья цифра равна {(a/1000)%10}");
if (a>=1000000&&a<=9999999) Console.WriteLine($"Третья цифра равна {(a/10000)%10}");
if (a>=10000000&&a<=99999999) Console.WriteLine($"Третья цифра равна {(a/100000)%10}");
if (a>=100000000&&a<=999999999) Console.WriteLine($"Третья цифра равна {(a/1000000)%10}");
if (a>=1000000000&&a<=2147483647) Console.WriteLine($"Третья цифра равна {(a/10000000)%10}");
if (a==2147483647) Console.WriteLine("Введено последнее 32-разрядное целое число");
