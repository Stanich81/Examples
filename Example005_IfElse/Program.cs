Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("О, привет, Маша!!!");
}
else
{
    Console.Write("Опять ты, ");
    Console.Write(username);
    Console.Write("?");
}
