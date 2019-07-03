using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region upcasting,downcasting,polymorfism
            //Animal shark = new Shark();
            //object eagle = new Eagle();
            //object a = 5;

            ////Eagle eagle2 = eagle as Eagle;

            //if(a is Eagle)
            //{
            //    Eagle eagle2 = (Eagle)a;
            //}
            //else
            //{
            //    Console.WriteLine("Eagle tipinden deyil");
            //}
            #endregion

            //Kelvin kelvin = new Kelvin();
            //kelvin.Degree = 30;
            //Dollar usd = new Dollar { Usd = 30 };
            //Manat azn = (Manat)usd;
            //Console.WriteLine(azn.Azn);

            Manat azn = new Manat { Azn = 20 };
            Manat azn1 = new Manat { Azn = 30 };
            Console.WriteLine(azn1==azn);
        }

    }

    class Manat
    {
        public int Azn { get; set; }

        public static bool operator >(Manat azn1, Manat azn2)
        {
            return azn1.Azn > azn2.Azn;
        }

        public static bool operator <(Manat azn1, Manat azn2)
        {
            return azn1.Azn < azn2.Azn;
        }
        public static bool operator ==(Manat azn1, Manat azn2)
        {
            return azn1.Azn == azn2.Azn;
        }

        public static bool operator !=(Manat azn1, Manat azn2)
        {
            return azn1.Azn != azn2.Azn;
        }

        public static int operator -(Manat azn1,Manat azn2)
        {
            return azn1.Azn - azn2.Azn;
        }

        public static int operator +(Manat azn1,Manat azn2)
        {
            return azn1.Azn + azn2.Azn;
        }
    }

    class Dollar
    {
        public int Usd { get; set; }

        public static explicit operator Manat(Dollar usd)
        {
            return new Manat { Azn = usd.Usd * 2 };
        }
    }

    #region upcasting,downcasting,polymorfism
    //abstract class Animal
    //{
    //    public abstract void Eat();
    //}

    //abstract class Bird : Animal
    //{
    //    public abstract void Fly();

    //    public void ICanFly()
    //    {
    //        Console.WriteLine("Not all birds flying");
    //    }
    //}

    //abstract class Fish : Animal
    //{

    //}

    //class Shark : Fish
    //{
    //    public int MyProperty { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("I am eating fishes");
    //    }
    //}

    //class Eagle : Bird
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eagle is eating");
    //    }

    //    public override void Fly()
    //    {
    //        Console.WriteLine("Eagle is flying");
    //    }

    //    public void Hunting()
    //    {
    //        Console.WriteLine("I am hunter");
    //    }
    //}
    #endregion
}
