using System;
using System.Collections;


namespace RevisaoModulo09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            ba1.SetAll(true);
            ba2.SetAll(false);
            ba1.Set(2, false);
            ba2.Set(3, true);
            Console.Write(ba1.And(ba2).Get(3));*/
            
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            ba1.SetAll(true);
            ba2.SetAll(false);
            ba1.Set(2, false);
            ba2.Set(3, true);
            Console.Write(ba1.And(ba2).Get(2));
        }
    }
}