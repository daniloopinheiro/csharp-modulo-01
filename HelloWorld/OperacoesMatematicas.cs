namespace HelloWorld;

public class OperacoesMatematicas
{
    public (int resultadoDaAdicao, string autor) Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        return (resultado, "Welisson");
    }

    public void Teste(int valor1, int valor2 = 7, string autor = "welisson")
    {
        Console.WriteLine(valor1 + valor2);
        Console.WriteLine(autor);
    }
}
