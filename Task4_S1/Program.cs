// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите число N => ");                              
string n = Console.ReadLine();                            
int N = int.Parse(n);   
int i=0-N;
while (i<=N)
{
   if (i%2==0)
   {
        Console.Write(i+" ");   
   } 
   i++;    
}