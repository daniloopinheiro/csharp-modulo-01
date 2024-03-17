namespace HelloWorld;

class Carro
{
    public void Ligar()
    {
        Console.WriteLine("carro LIGADO");
    }

    public void Desligar()
    {
        Console.WriteLine("carro DESLIGADO");
    }

        private void Teste1()
    {
        Console.WriteLine("Teste 1");
    }

    internal void Teste2()
    {
        Teste1();
        Console.WriteLine("Teste 2");
    }
}
