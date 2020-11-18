using System;

namespace Tutlane
{
    class Maths
    {
        // Declare the delegate
        public delegate void SampleDelegate();

        //Declare an event
        public event SampleDelegate SampleEvent;

        public void Add(int a, int b)
        {
            // Calling event delegate to check subscription
            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Add Result: {0}", a + b);
            }

            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }

        public void Subtract(int x, int y)
        {
            // Calling event delegate to check subscription

            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Subtract Result: {0}", x - y);
            }

            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
    }

    class Operations
    {
        Maths m;
        public int a { get; set; }
        public int b { get; set; }

        public Operations(int x, int y)
        {
            m = new Maths();
            // Subscribe to SampleEvent event
            m.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }

        // SampleEvent Handler

        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");
        }

        public void AddOperation()
        {
            m.Add(a, b);
        }

        public void SubOperation()
        {
            m.Subtract(a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Events Example****");
            Operations op = new Operations(10, 20);
            op.AddOperation();
            op.SubOperation();
            Console.ReadLine();
        }
    }
}