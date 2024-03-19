namespace HelloWorld;

class Program
{
    static void Main()
    {
        int[,] inteiros = new int[10, 10];

        inteiros[0,0] = 1;
        inteiros[0, 3] = 2;

        Console.WriteLine(inteiros[0,0]);
        Console.WriteLine(inteiros[0,1]);
        Console.WriteLine(inteiros[0,2]);
        Console.WriteLine(inteiros[0,3]);
    }
}
