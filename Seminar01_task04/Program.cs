System.Console.WriteLine("Введите N: ");
int s = int.Parse(Console.ReadLine());

for (int i = -s; i <= s; i++)
{
  System.Console.WriteLine(i);
}

System.Console.WriteLine("Введите N: ");
int y = int.Parse(Console.ReadLine());
if (y >= 100 && y < 1000)
{
  System.Console.WriteLine(y % 10);
}
else
{
  System.Console.WriteLine("Это не трехзначное число");
}
