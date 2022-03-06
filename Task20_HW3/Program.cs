//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int N=Prompt("Введите число N =>  ");
for (int i=1; i<=N; i++)
{
   int valye=i*i*i;
   Console.Write(valye+" ");
}
