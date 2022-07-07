Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "миша")
{
    Console.WriteLine("Да это же наш повелитель!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
