using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTest"), InternalsVisibleTo("GuiApp")]
namespace Lab1
{
    internal class Result
    {
        private int weight {  get; set; }
        private int value { get; set; }
        public List<Item> items { get; set; }

        public Result (List <Item> items, int value, int weight)
        {
            this.items = items;
            this.weight = weight;
            this.value = value;
        }
        public override string ToString()
        {
            string listaItemowIds = string.Join(", ", items.Select(Item => Item.id));
            return $"Items: {listaItemowIds}{Environment.NewLine}Full Weight: {weight}{Environment.NewLine}Full Value: {value}";
        }
    }
}
