using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    //delegate class 내부,외부 에서 선언할 수 있음
    class Program
    {
        public delegate void TestDelegate();

        public delegate void CustomDelegate();
        public void Method(CustomDelegate customDelegate)
        {
            customDelegate();
        }

        static void Main(string[] args)
        {
            TestDelegate delegateA=TestMethod;
            TestDelegate delegateB=delegate() { };
            TestDelegate delegateC = () => { };

            delegateA();
            delegateB();
            delegateC();
        }
        static void TestMethod()
        {

        }
    }
}
