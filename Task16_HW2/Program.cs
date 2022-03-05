Console.Write("Введите номер дня недели => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A);
if (a>0&&a<8)
{
    if (a>5&&a<8) Console.WriteLine("Выходной день!");
    else Console.WriteLine("Рабочий день");
}    
else Console.WriteLine("Только 7 дней в неделе!");

// if (a>0&&a<8)
//{
//    if (a==6||a==7) Console.WriteLine("Выходной день!");
//    else Console.WriteLine("Рабочий день");
//}    
// else Console.WriteLine("Только 7 дней в неделе!");
