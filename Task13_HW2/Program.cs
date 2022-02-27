Console.Write("Введите трехзначное число => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A);
if (a<=999&&a>=100) Console.WriteLine($"Вторая цифра трехзначного числа равна {a/10%10}");
else Console.WriteLine($"Введено не трехзначное число");