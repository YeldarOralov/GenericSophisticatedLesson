using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSophisticatedLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker<Director> checker = new Checker<Director>();
            checker.MakeCheck(new Director());
        }
    }
}
