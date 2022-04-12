Console.Clear();
Console.WriteLine("Для сравнения введите 3 числа");
Console.WriteLine("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
 {
    max = b;    
 }    
if (c > max)
 {
    max = c;
 }    
Console.WriteLine($"Max = {max}");