using Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyReflection
{
    internal class GetMethod
    {
        public static void Invoke()
        {
            Type type = typeof(Test3);
            var instance1 = Activator.CreateInstance(type) as Test3;
            
            var method = type.GetMethod("OutPut",Type.EmptyTypes);

            foreach (var parameter in method.GetParameters())
            {
                
            }
        }
    }
}
