// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (num == 3)
{
    System.Console.WriteLine("Среда");
}
else if (num == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (num == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (num == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (num == 7)
{
    System.Console.WriteLine("Воскресенье");
}   
else
{
    System.Console.WriteLine("Такого дня недели нет");
}