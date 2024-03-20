namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();

        (int resultado, string nome) = matematica.Adicionar(7, 3);

        Console.WriteLine(resultado);
        Console.WriteLine(nome);
    }
}
