Console.Write("Введите номер дня недели => ");                              
string A = Console.ReadLine();                            
int a = int.Parse(A); 
if (a<8&&a>0)
{
    if (a==1) Console.WriteLine("Понедельник!");
    if (a==2) Console.WriteLine("Вторник!");
    if (a==3) Console.WriteLine("Среда!");
    if (a==4) Console.WriteLine("Четверг!");
    if (a==5) Console.WriteLine("Пятница!");
    if (a==6) Console.WriteLine("Суббота!");
    if (a==7) Console.WriteLine("Воскресенье!");
    
}
else
{
    Console.WriteLine("Только 7 дней в неделе!");
}