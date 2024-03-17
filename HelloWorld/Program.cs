namespace HelloWorld;

class Program
{
    static void Main()
    {
        char letra = 'a';
        char numero = '1';
        char caracter = '@';
        char espaco = ' ';

        string texto = "Este curso é muito bom";
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "            Wellison Arley             ";
        string nomeSemEspaco = meuNome.Trim();

        string textoAposReplace = nomeSemEspaco.Replace('e','7');

        Console.WriteLine(textoAposReplace);
    }
}
