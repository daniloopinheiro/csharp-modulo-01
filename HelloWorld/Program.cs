namespace HelloWorld;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dicionario = new Dictionary<string, int>();

        dicionario.Add("welisson", 1);
        dicionario.Add("Edilaine", 0);
        dicionario.Add("Willian", 7);

        bool existe = dicionario.ContainsKey("Welisson");

        Console.WriteLine(existe);
    }
}
