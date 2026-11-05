
namespace StreamingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie a = new Movie("A",2020,128);
            Console.WriteLine(a.GetDescription());
            Series b = new Series("B", 2022, 10, 45);
            Console.WriteLine(b.GetDescription());
            Console.WriteLine(a.Watch(100));
            Console.WriteLine(a.Watch(50));
            Console.WriteLine(a.WatchedMin);
            Console.WriteLine(a.IsFinished);
            Console.WriteLine(a.Watch(10));
        }
    }
}
