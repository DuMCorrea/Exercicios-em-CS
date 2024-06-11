using System;

class Retangulo
{
    public double Largura { get; }
    public double Altura { get; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }

    public bool EQuadrado()
    {
        return Largura == Altura;
    }
}