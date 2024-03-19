namespace HelloWorld;

class Program
{
    static void Main()
    {
        List<string> strings = new List<string>();

        strings.Add("Hello");
        strings.Add("Mundo");
        strings.Add("Welisson");
        strings.Add("Arley");

        string resultado = string.Join("Oi", strings);

        Console.WriteLine(resultado);
    }
}
