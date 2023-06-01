using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() }

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            // 이렇게도 함
            // List<Object> Things = new List<Object>() { new Dog(), new Dog(), new Dog() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
                 
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();

            }
        }
    }
}
