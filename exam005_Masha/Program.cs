Console.Write("введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine ("Ура! Это же Masha");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}