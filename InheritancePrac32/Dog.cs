using System;

namespace InheritancePrac32
{
    public class Dog
    {


        public int Age { get; set; }    
        public string Color { get; set; }
        public Dog()
        {
            this.Age = 0; 
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Meow()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}