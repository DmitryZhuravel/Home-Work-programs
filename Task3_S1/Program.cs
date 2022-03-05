Console.Clear();
int y = 0;
while (y < 12)
{
    int x=y*y;
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    y++;
}
