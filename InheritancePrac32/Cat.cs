using System;

namespace InheritancePrac32
{
    /// <summary> (/ 세 번하면 자동으로 뜬다)
    /// 고양이 클래스
    /// </summary>

    public abstract class Cat : Animal
    {
        public Cat() : base(2) { }    

        public Cat(int age) : base(age)
        { 
        }

        public sealed override void Eat() //sealed: 더 이상 오버라이딩 할 수 없게 막음
        {
            Console.WriteLine("고양이: 자박자박 먹습니다");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}