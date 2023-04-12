Console.Write("Введите число: ");

string s = Console.ReadLine();
// int i = int.Parse(s); //преобразование строки в число
int i;

if (int.TryParse(s, out i))
{
  System.Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
}
else
{
  System.Console.WriteLine("Upssss");
}

// System.Console.WriteLine("Квадрат числа " + i + " = " + i * i);
// System.Console.WriteLine("Квадрат числа " + i + " = " + Math.Pow(i, 2));
// System.Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");

