namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, seed, capacity;
            Console.WriteLine("Podaj ilosc przedmiotow:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ziarno (seed):");
            seed = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemnosc plecaka:");
            capacity = int.Parse(Console.ReadLine());
            Problem problem = new Problem(n,seed);
            Console.WriteLine(problem);
            Result result = problem.solve(capacity);
            Console.WriteLine(result);
        }
    }
}
