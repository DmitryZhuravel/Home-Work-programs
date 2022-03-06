//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int x1=Prompt("Введите значение координаты x1 =>  ");
int y1=Prompt("Введите значение координаты y1 =>  ");
int z1=Prompt("Введите значение координаты z1 =>  ");
int x2=Prompt("Введите значение координаты x2 =>  ");
int y2=Prompt("Введите значение координаты y2 =>  ");
int z2=Prompt("Введите значение координаты z2 =>  ");

int x=x2-x1; 
int y=y2-y1;
int z=z2-z1;
double distance=Math.Sqrt(x*x+y*y+z*z);

Console.Write($"Расстояние между двуми точками в пространстве равно {distance}");

