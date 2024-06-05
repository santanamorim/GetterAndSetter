using System;

public class Produto
{
    private string _nome;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public decimal Preco
    {
        get { return _preco; }
        set
        {
            if (value >= 0)
                _preco = value;
            else
                throw new ArgumentException("O preço deve ser maior ou igual a zero.");
        }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set
        {
            if (value >= 0)
                _quantidade = value;
            else
                throw new ArgumentException("A quantidade deve ser maior ou igual a zero.");
        }
    }

    public decimal ValorEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Notebook", 3000m, 10);
        Console.WriteLine($"Nome do produto: {produto.Nome}");
        Console.WriteLine($"Preço do produto: {produto.Preco}");
        Console.WriteLine($"Quantidade do produto: {produto.Quantidade}");
        Console.WriteLine($"Valor total em estoque: {produto.ValorEmEstoque()}");

        produto.Preco = 3200m;
        produto.Quantidade = 8;
        Console.WriteLine($"Novo preço do produto: {produto.Preco}");
        Console.WriteLine($"Nova quantidade do produto: {produto.Quantidade}");
        Console.WriteLine($"Novo valor total em estoque: {produto.ValorEmEstoque()}");
    }
}

