using System;

namespace InheritancePrac32
{
    /// <summary> (/ 세 번하면 자동으로 뜬다)
    /// 고양이 클래스
    /// </summary>

    internal class Cat : Animal
    {
        public Cat() : base(2) { }    

        public Cat(int age) : base(age)
        { 
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}