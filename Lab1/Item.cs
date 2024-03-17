using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTest"), InternalsVisibleTo("GuiApp")]
namespace Lab1
{
    internal class Item
    {
        public int value {  get; set; }
        public int weight { get; set; }
        public int id { get; set; }
        public float ratio { get; set; }
        
        public Item (int id, int v, int w)
        {
            this.id = id;
            this.value = v;
            this.weight = w;
            this.ratio = (float)v / (float)w;
        }
        public override string ToString()
        {
            return $"No: {id}     Value: {value}     Weight: {weight}";
        }
    }
}
