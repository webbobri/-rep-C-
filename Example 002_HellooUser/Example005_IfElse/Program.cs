Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower == "маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}