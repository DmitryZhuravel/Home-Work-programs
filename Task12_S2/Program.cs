// Напишите программу, которая принимает на вход//число и проверяет, 
// кратно ли оно одновременно 7 и 23.
int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int a=Prompt("Введите число a =>  ");
if (a%7==0&&a%23==0) Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
if (a%7==0&&a%23!=0) Console.WriteLine($"Число {a} кратно 7 и не кратно 23");
if (a%7!=0&&a%23==0) Console.WriteLine($"Число {a} не кратно 7 и кратно 23");
if (a%7!=0&&a%23!=0) Console.WriteLine($"Число {a} не кратно 7 и не кратно 23");

