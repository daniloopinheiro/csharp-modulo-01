namespace HelloWorld;

class Program
{
    static void Main()
    {
        DataOnly dia = new DataOnly(2023, 12, 1);

        string diaEmTexto = dia.ToString("d MMMM yyyy", new CultureInfo("pt-BR"));

        Console.WriteLine(dia);
    }
}
