using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Reflection;

namespace AssemblyReflection
{
    public class GetFields
    {
        public static void GetClassFields()
        {
            FieldInfo[] fields = typeof(Test4).GetFields(BindingFlags.Public |
                                                         BindingFlags.Instance |
                                                         BindingFlags.Static);

            foreach (FieldInfo item in fields)
            {
                string name = item.Name; //名称
                object? value = item.GetValue(typeof(Test4));  //值
            }
        }
    }
}
