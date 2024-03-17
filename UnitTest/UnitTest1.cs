using Lab1;
using Newtonsoft.Json.Bson;
using System.Reflection.Emit;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes )
            {
                Problem problem = new Problem(n,1);
                Assert.AreEqual(n, problem.items.Count);
            }
        }
        [TestMethod]
        public void min_jeden_item()
        {
            int n = 10;
            int seed = 1;
            int capacity = 100;
            int min = 0;
            int is_full = 0;
            Problem problem = new Problem(n, seed);
            for (int i = 0; i < n; i++)
            {
                if (problem.items[i].weight < capacity)
                    min = 1;
            }
            Result wynik = problem.solve(capacity);
            if (wynik.items.Count != 0)
                is_full = 1;
            else
                is_full = 0;
            Assert.AreEqual(min, is_full);
        }
        [TestMethod]
        public void wynik_instancji()
        {
            int n = 10;
            int seed = 1;
            int capacity = 10;
            List<int> oczekiwany = new List<int>();
            oczekiwany.Add(0);
            oczekiwany.Add(2);
            oczekiwany.Add(5);

            Problem problem = new Problem(n, seed);
            Result result = problem.solve(capacity);
            Assert.AreEqual(oczekiwany.Count, result.items.Count);
            for (int i = 0;i < oczekiwany.Count; i++)
            {
                Assert.AreEqual(oczekiwany[i], result.items[i].id);
            }
        }
        [TestMethod]
        public void zero_capacity()
        {
            int n = 50;
            int seed = 1;
            int capacity = 0;
            int is_full = 0;
            Problem problem = new Problem(n, seed);
            Result wynik = problem.solve(capacity);
            if (wynik.items.Count != 0)
                is_full = 1;
            else
                is_full = 0;
            Assert.AreEqual(0, is_full);
        }
        [TestMethod]
        public void kolejnosc()
        {
            int n = 10;
            int seed = 1;
            int capacity = 10;
            Problem problem1 = new Problem(n,seed);
            Problem problem2 = new Problem(n,seed);

            Result result1 = problem1.solve(capacity);
            for (int i = 0; i < problem2.items.Count/2; i++)
            {
                Item tmp = problem2.items[i];
                problem2.items[i] = problem2.items[^(i+1)];
                problem2.items[^(i+1)] = tmp;
            }
            Result result2 = problem2.solve(capacity);
            Assert.AreEqual(result1.ToString(), result2.ToString());
        }
        [TestMethod]
        public void Negative_amount()
        {
            int n = -2;
            int seed = 1;
            int capacity = 10;
            Problem problem = new Problem(n, seed);
            Result result = problem.solve(capacity);
            Assert.AreEqual(result.items.Count, 0);
        }
        [TestMethod]
        public void Negative_capacity()
        {
            int n = 10;
            int seed = 1;
            int capacity = -10;
            Problem problem = new Problem(n, seed);
            Result result = problem.solve(capacity);
            Assert.AreEqual(result.items.Count, 0);
        }
    }
}