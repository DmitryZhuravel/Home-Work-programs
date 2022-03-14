Random rnd=new Random();
int value=rnd.Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {value}");
Console.Write($"Число без второй цифры {value/100}{value%10}");
