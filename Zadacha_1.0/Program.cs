Console.Write("Введи трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = numberA % 10;

Console.WriteLine("Последнее число: " + numberB);
