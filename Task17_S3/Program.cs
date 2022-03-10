// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int a=Prompt("Введите номер четверти =>  ");
if (a>=1&&a<=4)
{
    if (a==1) Console.WriteLine("Точка принимает значения X>0 и Y>0");
    if (a==2) Console.WriteLine("Точка принимает значения X<0 и Y>0");
    if (a==3) Console.WriteLine("Точка принимает значения X<0 и Y<0");
    if (a==4) Console.WriteLine("Точка принимает значения X>0 и Y<0");
}
else Console.WriteLine($"Введенное значение не соответствует заданым четвертям");