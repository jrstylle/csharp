namespace WordCharacterCounter;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        string? userInput = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Nenhuma palavra foi digitada");
            return;
        }

        string[] words = userInput.Split(' ');

        foreach (string word in words)
        { 
            Console.WriteLine($"A palavra '{word}' tem {word.Length} caracteres");
        }
    }
}