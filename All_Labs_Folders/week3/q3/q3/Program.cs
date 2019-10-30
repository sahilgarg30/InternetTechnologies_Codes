using System;
namespace q3
{
    public delegate void TrafficDel();

    class TrafficSignal
    {
        public void Yellow()
        {
            Console.WriteLine("Yellow");
        }
        public void Green()
        {
            Console.WriteLine("Green");
        }
        public void Red()
        {
            Console.WriteLine("Red");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TrafficDel functionRef;
            TrafficSignal signal = new TrafficSignal();
            functionRef = signal.Yellow;
            functionRef();
            functionRef = signal.Green;
            functionRef();
            functionRef = signal.Red;
            functionRef();
            Console.Read();
        }
    }
}
