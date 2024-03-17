namespace HelloWorld;

class Program
{
    static void Main()
    {
        string texto1 = "A primeira frase.";
        string texto2 = "Segunda frase";

        string paragrafo = texto1 + " " + 7 + " " + true + " " + texto2;

        string paragrafo2 = $"A primeira frase. {7} {true} segunda frase.";

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);

        string resultado = stringBuilder.ToString();

        Console.WriteLine(resultado);
    }
}
