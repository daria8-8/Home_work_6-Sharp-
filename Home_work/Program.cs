
void Ex41()
{Console.Write("Введите колличество чисел: ");
int M = int.Parse(Console.ReadLine()?? "0");
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int m = int.Parse(Console.ReadLine()?? "0");
    if (m > 0)
        count++;
}
Console.WriteLine($"Чисел больше 0: {count}");
}

void Ex43()
{
Console.WriteLine("введите значение b1");
double b1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("введите число k1");
double k1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("введите значение b2");
double b2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("введите число k2");
double k2 = int.Parse(Console.ReadLine()?? "0");

// y = k1 * x + b1
// y = k2 * x + b2
// k1*x+b1 = k2*x+b2
// k1*x = k2*x+b2-b1
// x*(k1-k2)=(b2-b1)
// x=(b2-b1)/(k1-k2)
double x = (b2-b1)/(k1-k2);
// y = k1 * x + b1
// x=(b2-b1)/(k1-k2)
double y = k1 *((b2-b1)/(k1-k2)) + b1; 
// y = k2 * x + b2
// x=(b2-b1)/(k1-k2)
// double y = k2 *((b2-b1)/(k1-k2)) + b2;(вторая формула нахождения y)
Console.WriteLine($"две прямые пересекутся в точке с координатами ({x}, {y})");
}

Ex41();
Ex43();