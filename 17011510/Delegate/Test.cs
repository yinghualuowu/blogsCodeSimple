using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public static class Test
    {
        public static void Foo()
        {
            List<Action> ac = new List<Action>();

            //for (int i = 0; i < 5; i++)
            //{
            //    var i1 = i;
            //    ac.Add(() => { Console.WriteLine(i1);});
            //}

            List<int> li = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var value in li)
            {
                ac.Add(() => { Console.WriteLine(value); });
            }

            foreach (var action in ac)
            {
                action.Invoke();
            }
        }
    }
}
