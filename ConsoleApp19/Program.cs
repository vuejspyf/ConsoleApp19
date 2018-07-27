using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp19
{
    interface IFly
    {
        void Fly();
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Shout();
       // public abstract void Fly();
    }
    class Dog:Animal
    {
        public Dog(string name) : base(name) { }
        public override void Shout()
        {
            Console.WriteLine("{0}旺旺",base.Name);
        }
        //public override void Fly()
        //{
        //    // throw new NotImplementedException();
        //    Console.WriteLine("狗不能飞");
        //}

    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void Shout()
        {
            Console.WriteLine("{0}喵喵", base.Name);
        }
        //public override void Fly()
        //{
        //    Console.WriteLine("猫不能飞");
        //}
    }
    class Duck : Animal, IFly
    {
        public Duck(string name) : base(name) { }
        public override void Shout()
        {
            Console.WriteLine("{0}嘎嘎", base.Name);
        }
        public  void Fly()
        {
            Console.WriteLine("嘎嘎{0}飞的好开心啊！",base.Name);
        }

    }
    class Dove : Animal,IFly
    {
        public Dove(string name) : base(name) { }
        public override void Shout()
        {
            Console.WriteLine("{0}咕咕", base.Name);
        }
        public  void Fly()
        {
            Console.WriteLine("咕咕{0}飞的好开心啊！", base.Name);
        }

    }
    class Program
    {
        static void Iwanttofly(IFly fly)
        {
            fly.Fly();
        }


        static void Main(string[] args)
        {
            Iwanttofly(new Dove("小黑"));
            
            Console.ReadKey();

        }
    }
    }

