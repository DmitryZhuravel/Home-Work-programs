Random rnd=new Random();
int value=rnd.Next(100, 999);
Console.WriteLine($"Случайное трехзначное число {value}");
int number1=value/100%10;
int number2=value%10;
Console.Write("Число без второй цифры ");
Console.Write(number1);
Console.Write(number2);
