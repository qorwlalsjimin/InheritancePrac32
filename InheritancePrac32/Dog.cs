using System;

namespace InheritancePrac32
{
    public class Dog : Animal
    {


        //public int Age { get; set; }   //하이딩!!

        public string Color { get; set; }
        public Dog()
        {
            this.Age = 0; 
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }

        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }
    }
}