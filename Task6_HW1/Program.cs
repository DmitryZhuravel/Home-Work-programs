Console.Write("Введите число А => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A);     
Console.Write("Введите число B => ");                              
string B = Console.ReadLine();                            
int b = int.Parse(B);
Console.Write("Введите число C => ");                              
string C = Console.ReadLine();                            
int c = int.Parse(C);     
int max=a;
if(b>max) max=b;
if(c>max) max=c;
Console.WriteLine($"Максимальное число ={max}");

int Prompt(string message)
{
    Console.Write(message);
    string strInput=Console.ReadLine();
    int answer=int.Parse(strInput);
    return answer;
}
int d=Prompt("Введите число a =>  ");
int f=Prompt("Введите число b =>  ");
int j=Prompt("Введите число c =>  ");
int maxx=a;
if (f>maxx) maxx=f;
if (j>maxx) maxx=j;
Console.WriteLine($"Максимальное число ={maxx}");