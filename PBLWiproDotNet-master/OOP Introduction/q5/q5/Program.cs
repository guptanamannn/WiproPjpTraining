using System;

namespace q5
{
    class Program
    {
        static void Main(string[] args)
        {
            FAN.Fan f1 = new FAN.Fan();
            f1.print();
            f1.Speed = 2;
            f1.On = false;
            f1.print();
            f1.Speed = 4;
            f1.On = true;
            f1.print();
            FAN.Fan f2 = new FAN.Fan();
            f2.print();
            f2.Speed = 0;
            f2.print();
            f2.Speed = 3;
            f2.print();
        }
    }
}
