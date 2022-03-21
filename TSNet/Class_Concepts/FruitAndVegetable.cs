using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSNet.Class_Concepts
{
    internal class FruitAndVegetable
    {
        public string fruit_name, fruit_color, vegetable_name, vegetable_color ;
        public FruitAndVegetable(string fruit_name, string fruit_color, string vegetable_name, string vegetable_color)
        {
            //this.name = name;
            //this.color = color;
            this.fruit_name = fruit_name;
            this.fruit_color = fruit_color;
            this.vegetable_name = vegetable_name;
            this.vegetable_color = vegetable_color;
        }
        static void main(string[] args)
        {
            FruitAndVegetable fruitAndVegetable = new FruitAndVegetable("Banana", "yellow", "Potato", "Brown");
            Console.WriteLine("\nFruit Name "+fruitAndVegetable.fruit_name);
        }
    }
}
