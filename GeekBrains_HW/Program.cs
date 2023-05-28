// дз 1 задача 1;
Console.Clear();
int max = 0;
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

if (a > b)
 {
 max = a;
 }
else 
{max = b;
}
int result = max;

Console.WriteLine(result);

