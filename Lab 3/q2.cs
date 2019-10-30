using System;
namespace q2
{
    class Item
    {
        public static decimal cost = 500;
        public string Name { get; set; }

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
            Console.WriteLine("{0} : {1}", item.Name, item.calcGst());
            Console.Read();
        }
    }
}
