using HW17.Models;

namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<string, int> pair = new Pair<string, int>();
            pair.Add("A", 15);
            pair.Add("B",20);
            pair.Add("B",50);
            Console.WriteLine(pair["A"]);
        }
    }
}
