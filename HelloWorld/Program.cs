namespace HelloWorld;

class Program
{
    static void Main()
    {
        string texto = "O usuario {0} gosta do numero {1}";

        string resultado = string.Format(texto, "Welisson", 7);

        Console.WriteLine(resultado);
    }
}
