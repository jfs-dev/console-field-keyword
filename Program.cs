using console_field_keyword.Entities;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nUsuário válido");
Console.WriteLine("--------------");

var user = new User {Name = "Peter Parker", Age = 18 };

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(user.ToString());


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nNome nulo");
Console.WriteLine("---------");

try
{
    #pragma warning disable CS8625
    user.Name = null;
    #pragma warning restore CS8625
}
catch (ArgumentNullException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nNome inválido");
Console.WriteLine("-------------");
try
{
    user.Name = "Pe";
}
catch (ArgumentException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nIdade inválida");
Console.WriteLine("--------------");
try
{
    user.Age = 15;
}
catch (ArgumentOutOfRangeException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erro: {ex.Message}");
}
