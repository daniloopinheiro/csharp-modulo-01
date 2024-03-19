namespace HelloWorld;

class Program
{
    static void Main()
    {
        List<int> inteiros = new List<int>();

        inteiros.Add(1);
        inteiros.Add(2);

        inteiros.Remove(0);

        inteiros.Clear();

        Console.WriteLine(inteiros.Count);
    }
}
