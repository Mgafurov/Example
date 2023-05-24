Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "малик")
{
    System.Console.WriteLine("Ура , это же Малик!");
}
else
{
    System.Console.Write("Привет,");
    System.Console.WriteLine(username);
}