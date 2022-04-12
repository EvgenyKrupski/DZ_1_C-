Console.Write("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int numbermax = numberA;

if (numberB > numberA)
{
    numbermax = numberB;
}
if (numberC > numberA)
{
    numbermax = numberC;
}
if (numberB > numberC)
{
    numbermax = numberB;
}  
Console.Write("max = " + numbermax);