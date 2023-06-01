using System;
namespace InheritancePrac32
{
    public class Animal
    {
        /// <summary>
        /// 고양이 나이
        /// </summary>


        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }

        private void Private() { }
        protected void Protected() { }
        public void Public() { }

        public void TestA()
        {
            Private();
            Protected();
            Public();
        }

    }
}