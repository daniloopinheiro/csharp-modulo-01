namespace HelloWorld;

class Program
{
    static void Main()
    {
        var carro = new Carro("Lamborghino")
        {
            LancadoEm = new DateOnly(2021, 01, 01),
            Cor = Cor.Azul
        };

        var carro2 = new Carro("Porche")
        {
            LancadoEm = new DateOnly(2019, 01, 01),
            Cor = Cor.Vermelho
        };

        carro.NomeDoModelo();
    }
}
