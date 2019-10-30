using System;
namespace q2
{
    class Item
    {
        public static decimal cost = 500;
        public string Name { get; set; }
        public static decimal Cost
        {
            get { return cost; }
            set { if (value > 0) cost = value; }
        }

        public decimal calcGst()
        {
            decimal res = Decimal.Multiply(cost,8);
            res = Decimal.Divide(res, 100);
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Name = "Item1";
            Item.Cost = -200;
            Item item2 = new Item();
            Console.WriteLine("{0} : {1}", item.calcGst(), item2.calcGst());
            Console.Read();
        }
    }
}
