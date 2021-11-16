using System;
using System.Collections.Generic;

namespace Ресторан
{
    class Item
    {
        public string name;
        public double Price;
        public virtual double price { get { return Price; } set { Price = value; } }
        int ValueAddedTax;
        public int valueAddedTax { get { return ValueAddedTax; } set { ValueAddedTax = value; } }
        public Item(string name, double price, int valueAddedTax)
        {
            this.name = name;
            this.Price = price;
            this.ValueAddedTax = valueAddedTax;
        }
        static void AddItem(List<Item> list, Item item)
        {
            if (item is Drink)
            {
                if (Drink.volumes.Contains(Drink.volume))
                    list.Add(item);
                else
                    Console.WriteLine("Такого объема напитка не существует");
            }
            else
            {
                if (Food.amounts.Contains(Food.amount))
                {
                    list.Add(item);
                }
                else
                    Console.WriteLine("Такого количества продукта");
            }
        }
    }
    class Drink : Item
    {
        public static double volume;
        public static List<double> volumes;
        public Drink(string name, double price, int valueAddedTax, double volume_) : base(name, price, valueAddedTax)
        {
            volume = volume_;
        }
        public override double price { get { return Price * volume + valueAddedTax; } }
    }
    class Food : Item
    {
        public static int amount;
        public static List<int> amounts;
        public Food(string name, double price, int valueAddedTax, int amount_) : base(name, price, valueAddedTax)
        {
            amount = amount_;
        }
        public override double price { get { return Price * amount + valueAddedTax; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Drink("koka kola", 12, 1, 0.5));
            items.Add(new Drink("pepsi", 10, 1, 0.7));
            items.Add(new Food("burger", 13, 1, 1));
            items.Add(new Food("cheesburger", 15, 1, 2));
            foreach (Item i in items)
            {
                if (i is Drink)
                    Console.WriteLine(i.name + "; " + i.price + "; " + i.valueAddedTax + "; " + Drink.volume);
                else
                    Console.WriteLine(i.name + "; " + i.price + "; " + i.valueAddedTax + "; " + Food.amount);
            }
        }
    }
}
