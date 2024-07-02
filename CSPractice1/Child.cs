using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Child : Parent
    {
        public Child() : base("이미림")
        // : base("이미림")은 부모 생성자에 매개변수를 전달할 수 있다.
        {
            Console.WriteLine("자식 생성자 호출");
        }

        public Child(string name) : base(name)
        {

        }
    }
}
