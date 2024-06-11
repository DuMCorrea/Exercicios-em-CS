using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Escolha uma cor:");
        string corEscolhida = Console.ReadLine().ToLower();


        ExibirTipoDeCor(corEscolhida);
    }

    public static void ExibirTipoDeCor(string cor)
    {
        if (EhCorPrimaria(cor))
        {
            Console.WriteLine($"{cor} é uma cor primária.");
        }
        else if (EhCorSecundaria(cor))
        {
            Console.WriteLine($"{cor} é uma cor secundária.");
        }
        else if (EhCorTerciaria(cor))
        {
            Console.WriteLine($"{cor} é uma cor terciária.");
        }
        else
        {
            Console.WriteLine($"A cor {cor} não é reconhecida.");
        }
    }

    public static bool EhCorPrimaria(string cor)
    {

        return cor == "vermelho" || cor == "azul" || cor == "amarelo";
    }

    public static bool EhCorSecundaria(string cor)
    {

        return cor == "verde" || cor == "laranja" || cor == "roxo" || cor == "violeta";
    }

    public static bool EhCorTerciaria(string cor)
    {

        return cor == "vermelho-arroxeado" || cor == "vermelho-alaranjado" ||
               cor == "amarelo-esverdeado" || cor == "amarelo-alaranjado" ||
               cor == "azul-arroxeado" || cor == "azul-esverdeado";
    }
}