using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTest"), InternalsVisibleTo("GuiApp")]
namespace Lab1
{
    internal class Problem
    {
        private int n {  get; set; }
        private int seed { get; set; }

        public List<Item> items = new List<Item>();

        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            int id, v, w;
            Random random = new Random(this.seed);
            for (int i = 0; i < n; i++)
            {
                id = i;
                v=random.Next(1,10);
                w=random.Next(1,10);
                items.Add(new Item(id, v, w));
                //Console.WriteLine(items[i]);
            }
        }
        public Result solve(int capacity)
        {
            int current_weight = 0;
            int current_value = 0;
            List<Item> items_sorted = items.OrderByDescending(o => o.ratio).ToList();
            List<Item> backpack = new List<Item>();

            for (int i = 0; i < this.n; i++)
            {
                if (items_sorted[i].weight <= (capacity - current_weight))
                {
                    current_weight = current_weight + items_sorted[i].weight;
                    current_value = current_value + items_sorted[i].value;
                    backpack.Add(items_sorted[i]);
                }
            }
            Result result = new Result(backpack, current_value, current_weight);
            return result;
        }
        public override string ToString()
        {
            string listaItemowStr = string.Join(Environment.NewLine, items);
            return listaItemowStr;
        }
    }

}

