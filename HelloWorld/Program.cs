namespace HelloWorld;

class Program
{
    static void Main()
    {
        List<int> set = new List<int>();

        set.Add(1);
        set.Add(2);
        set.Add(1);

        Console.WriteLine(set.Count);
    }
}
