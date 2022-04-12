Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = Math.Abs(number);
}
for (int i = 2; i < number; i = i + 2)
{
    Console.Write($"{i}, ");
}
if (number%2 == 0)
{
    Console.Write($"{number}");
}
