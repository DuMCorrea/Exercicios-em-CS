class Program
{
    static void Main(string[] args)
    {

        Retangulo retangulo1 = new Retangulo(5, 7);
        Console.WriteLine("Área do retângulo: " + retangulo1.CalcularArea());
        Console.WriteLine("Perímetro do retângulo: " + retangulo1.CalcularPerimetro());
        Console.WriteLine("É quadrado? " + retangulo1.EQuadrado());

    }
}