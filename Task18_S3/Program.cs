// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int x1=Prompt("Введите координату X1 =>  ");
int y1=Prompt("Введите координату Y1 =>  ");
int x2=Prompt("Введите координату X2 =>  ");
int y2=Prompt("Введите координату Y2 =>  ");
double value=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
Console.WriteLine($"Расстояние между точками равно {value}");