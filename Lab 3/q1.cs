using System;
namespace q1
{
    public delegate void PriceChangedEventHandler();

    class Item
    {
        public event PriceChangedEventHandler PriceChanged;
        string name;
        public int price;

        public void ChangeDetected()
        {
            Console.WriteLine("New price : {0}", price);
        }


        public int Price
        {
            set
            {
                price = value;
                if (PriceChanged != null) PriceChanged();
            }
            get
            {
                return price;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.PriceChanged += item.ChangeDetected;
            item.price = 10;
            item.Price = 20;
            Console.Read();
        }
    }
}
