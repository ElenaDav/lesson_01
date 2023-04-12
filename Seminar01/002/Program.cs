Console.WriteLine("Введите 1 числo: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 числo: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == (numberB * numberB))
  {
    System.Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
  }
else
  {
    System.Console.WriteLine("Upssss");
  }
