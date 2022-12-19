namespace Reflection
{
    public class Test1
    {
        
    }

    public class Test2
    {

    }

    public class Test3
    {
        private string PrivateValue { get; set; }

        public string PublicValue { get; set; } = "1";

        public bool PublicBoolValue { get; set; }

        public Test3()
        {
            
        }

        static Test3()
        {
            
        }

        public Test3(string value)
        {
            PublicValue = value;
        }

        public Test3(string value,bool boolValue)
        {
            PublicValue = value;
            PublicBoolValue = boolValue;
        }

        private Test3(string privateValue,string publicValue)
        {
            PrivateValue = privateValue;
            PublicValue = publicValue;
        }

        public void OutPut()
        {
            Console.WriteLine(PublicValue);
        }

        public void OutPut(int param)
        {
            PublicValue += param;
            Console.WriteLine(PublicValue);
        }

        public void OutPut(bool param)
        {
            PublicBoolValue = param;
            Console.WriteLine(PublicValue);
        }
    }

    public class Test4
    {
        public static string Key1 = "1";
        public const string Key2 = "2";
    }
}