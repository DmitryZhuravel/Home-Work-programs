Console.Write("Введите число А => ");                              
string A = Console.ReadLine();                            
int numberA = int.Parse(A);     
Console.Write("Введите число B => ");                              
string B = Console.ReadLine();                            
int numberB = int.Parse(B);     
if (numberA == numberB)
{
   Console.WriteLine("а равно b");
}
else 
  if (numberA<numberB)
  {
    Console.WriteLine("b большее");
    Console.WriteLine("a меньшее");
  }
  else
  { 
    Console.WriteLine("a большее");
    Console.WriteLine("b меньшее");
  }
