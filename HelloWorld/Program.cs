namespace HelloWorld;

class Program
{
    static void Main()
    {
       int numero = 8;

       string resultado = numero switch
       {
            7 => "Welisson",
            1 => "Willian",
            3 => "Edilaine",
            _ => "Nome desconhecido"
       }

       Console.WriteLine(resultado);
    }
}
