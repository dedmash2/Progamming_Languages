Console.WriteLine("Введите ваше имя: ");
string userName = Console.ReadLine() ?? "";

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ого. Это же Маша!");
}else
{
    Console.WriteLine($"Приветствую, {userName}");
}
