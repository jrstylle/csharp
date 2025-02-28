namespace Welcome;

class Program
{
    static void Main()
    {   
        Console.WriteLine("Digite seu nome: ");
        var name = Console.ReadLine();

        if (String.IsNullOrEmpty(name))
        {
            name = "Fulano";
        }

        Console.WriteLine($"Olá, {name}. Seja bem-vindo");

    }
}