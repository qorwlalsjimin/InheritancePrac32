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
            Dog dog = new Dog();
            dog.Public();
            //dog.Protected();
            //dog.Private();

            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() };

            //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            // 이렇게도 함
            // List<Object> Things = new List<Object>() { new Dog(), new Dog(), new Dog() };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                var _dog = item as Dog;
                if(_dog != null) { _dog.Bark(); }

                var _cat = item as Cat;
                if(_cat != null) { _cat.Meow(); }

                if (item is Dog)
                {
                    ((Dog)item).Bark(); //실행 오류
                }else if(item is Cat)
                {
                    ((Cat)item).Meow(); //실행 오류
                }
                 
            }
        }
    }
}
