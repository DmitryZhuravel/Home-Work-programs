Console.Clear();
int y = 0;
while (y < 12)
{
    int x=y*y;
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    y++;
}




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