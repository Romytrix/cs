using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject1
{
    public class InfatryMan
    {
        public int Weight;
        public int Height;
        public int Endurance;

        public bool IsSupply { get; set };

    }

    void attack()
    {
        if (IsSupply)
        {
            Console.WriteLine("He is supply, he can't attack!");
        }
        else (){
            Console.WriteLine("He attacked!");
        }
    }

    void Wait()
    {
        Console.WriteLine("He is waiting Ur command!");
    }
}
