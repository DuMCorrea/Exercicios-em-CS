using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua data de nascimento (dd/mm/yyyy ou apenas o ano):");
        string dataNascimentoStr = Console.ReadLine();

        DateTime dataNascimento;
        if (!DateTime.TryParse(dataNascimentoStr, out dataNascimento))
        {
            if (!int.TryParse(dataNascimentoStr, out int ano))
            {
                Console.WriteLine("Data de nascimento inválida.");
                return;
            }
            dataNascimento = new DateTime(ano, 1, 1);
        }

        int idade = CalcularIdade(dataNascimento);

        Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
    }

    public static int CalcularIdade(DateTime dataNascimento)
    {
        int idade = DateTime.Today.Year - dataNascimento.Year;

        if (dataNascimento.Date > DateTime.Today.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
}