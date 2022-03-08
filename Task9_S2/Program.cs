// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int a=Prompt("Введите значение координаты a =>  ");
if (a<=1000&&a>=100)
{
    Console.WriteLine($"Последняя цифра трехзначного числа равна {a%10}");
}
else Console.WriteLine("Введено не трехзначное число");