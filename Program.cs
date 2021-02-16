using System;

namespace DeepClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(new Point(10,10),100,100);
            Rectangle rectClone = (Rectangle)rect.Clone();
            rect.Move(new Point(30,50));
            Console.WriteLine("Hello World!");
        }
    }
}
