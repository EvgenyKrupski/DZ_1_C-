Console.Write("Введи число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = numberA % 2;

if (numberB == 0)
{
 Console.WriteLine("Да");   
}
else
{
    Console.WriteLine("Нет");
}
