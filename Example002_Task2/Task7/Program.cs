// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//   456 -> 6
//   782 -> 2
//   918 -> 8

System.Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100)
{

while(number / 1000 > 0)
{
    number /= 10;
}
int digit = number %10;
System.Console.WriteLine(digit);
}
else System.Console.WriteLine("Третьей цифры нет");