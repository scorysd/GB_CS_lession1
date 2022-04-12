Console.Clear();
Console.WriteLine("Для сравнения введите 2 числа");
Console.WriteLine("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
 {
     Console.WriteLine($"Max равен: {b}");
 }
else 
{
    Console.WriteLine($"Max равен: {a}");
}