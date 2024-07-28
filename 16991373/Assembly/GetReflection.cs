using Reflection;
using System.Reflection;

namespace AssemblyReflection
{
    internal static class GetReflection
    {
        public static void GetTypes()
        {
            var assembly = Assembly.Load("Reflection");
            foreach (var value in assembly.GetTypes())
            {
                Console.WriteLine(value.Name);
            }

            /*
             * 输出
             *Test1
             *Test2
             */
        }

        public static void GetTypeName()
        {
            Type type = typeof(Test1);
            Console.WriteLine(type.Name);
        }
    }
}
