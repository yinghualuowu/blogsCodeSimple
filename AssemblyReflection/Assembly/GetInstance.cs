using System.Reflection;
using Reflection;

namespace AssemblyReflection
{
    internal class GetInstance
    {
        public static void CreateInstance()
        {
            //对默认构造函数
            Type type = typeof(Test3);
            var instance1 = Activator.CreateInstance(type) as Test3;
            Console.WriteLine(instance1?.PublicValue);
        }

        public static void GetConstructInfo()
        {
            Type type = typeof(Test3);
            ConstructorInfo? publicDefaultConstructor = type.GetConstructor(Type.EmptyTypes);
            var instance = publicDefaultConstructor?.Invoke(null);
        }
    }
}
