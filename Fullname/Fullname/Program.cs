using System.Diagnostics;

namespace Fullname;

class Program
{
    static void Main()
    {   
        Console.WriteLine("Digite o seu primeiro nome: ");
        string? firstName = Console.ReadLine();

        Console.WriteLine("Digite o seu sobrenome: ");
        string? lastName = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(firstName)) firstName = "Fulano";
        if (String.IsNullOrWhiteSpace(lastName)) lastName = "de Tal";

        string fullName = CreateFullName(firstName, lastName);

        Console.WriteLine(fullName);


    }

    static string CreateFullName(string firstName, string lastName)
    {
        return $"Seu nome inteiro é: {firstName} {lastName}";
    }
}
