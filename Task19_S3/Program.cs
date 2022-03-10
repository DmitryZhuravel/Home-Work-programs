// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int n=Prompt("Введите число N =>  ");
for (int i=1; i<=n; i++) Console.Write(i*i+" ");

