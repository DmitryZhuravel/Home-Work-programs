Console.Write("Введите номер дня недели => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A);
if (a<8&&a>0)
{
    if (a==6||a==7) Console.WriteLine("Выходной день!");
    else Console.WriteLine("Рабочий день");
}    
else Console.WriteLine("Только 7 дней в неделе!");
