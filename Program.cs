Console.Clear();

Console.WriteLine("Введите значение X для A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение Y для A: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение Z для A: ");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение X для B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение Y для B: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение Z для B: ");
int zb = int.Parse(Console.ReadLine()!);

double l = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"Расстояние между точками = {l:f2}");