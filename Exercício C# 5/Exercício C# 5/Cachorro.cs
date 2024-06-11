using System;

class Cachorro
{
    private readonly string nome;
    private readonly string raca;
    private readonly double pesoOriginal;
    private double peso;
    private double energia;
    private bool vivo;

    public Cachorro(string nome, string raca, double peso)
    {
        this.nome = nome;
        this.raca = raca;
        this.pesoOriginal = peso;
        this.peso = peso;
        this.energia = 100;
        this.vivo = true;
    }

    public void Latir()
    {
        if (!vivo)
        {
            Console.WriteLine($"{nome} não está mais entre nós.");
            return;
        }

        energia -= 5;
        peso -= 0.2;

        VerificarEstado();
    }

    public void Correr()
    {
        if (!vivo)
        {
            Console.WriteLine($"{nome} não está mais entre nós.");
            return;
        }

        energia -= 15;
        peso -= 0.6;

        VerificarEstado();
    }

    public void Comer()
    {
        if (!vivo)
        {
            Console.WriteLine($"{nome} não está mais entre nós.");
            return;
        }

        energia += 45;
        peso += 1.8;

        if (peso > pesoOriginal * 1.5)
        {
            Console.WriteLine($"{nome} está ficando gordo e precisa correr!");
        }

        VerificarEstado();
    }

    private void VerificarEstado()
    {
        if (energia <= 0)
        {
            vivo = false;
            Console.WriteLine($"{nome} morreu de exaustão.");
        }
    }
}