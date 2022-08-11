Console.WriteLine("введите ваше имя, ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // ToLower() - позволяет все символы строки перевести в нижний регистр
{
    Console.WriteLine("хороша Маша, да не наша");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
