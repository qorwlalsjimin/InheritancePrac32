using System;

namespace InheritancePrac32
{
    /// <summary> (/ 세 번하면 자동으로 뜬다)
    /// 고양이 클래스
    /// </summary>

    internal class Cat
    {
        /// <summary>
        /// 고양이 나이
        /// </summary>
    

        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }


        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}