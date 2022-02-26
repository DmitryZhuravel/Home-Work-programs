Console.Write("Введите число => ");
string inputN = Console.ReadLine();
int N = int.Parse(inputN);
int i=1;
while (i<N)
{
  if (i%2==0) 
  Console.Write(i+" ");
  i=i+1;
}