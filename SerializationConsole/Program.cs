using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //This needs to be tested
            //Done.  Has to be the same length
            //How do you pass args using the Start button?!??!
            //It's in Project Properties under the Debug tab
            if (args[0] == "save")
            {
                SerializableClass sc = new SerializableClass();
                sc.StringProperty = "Hello World!";
                sc.IntegerProperty = 42;
                BinaryFormatter fmt = new BinaryFormatter();
                using (FileStream stm = File.OpenWrite(@"c:\temp\output.stm"))
                {
                    fmt.Serialize(stm, sc);
                }
            }
            if (args[0] == "load")
            {
                SerializableClass sc = new SerializableClass();
                BinaryFormatter fmt = new BinaryFormatter();
                using (FileStream stm = File.OpenRead(@"c:\temp\output.stm"))
                {
                    sc = (SerializableClass)fmt.Deserialize(stm);
                }
                Console.WriteLine(sc.StringProperty);
                Console.WriteLine(sc.IntegerProperty);
                Console.Read();
            }
        }
    }
    [Serializable]
    public class SerializableClass
    {
        public string StringProperty { get; set; }
        public int IntegerProperty { get; set; }
    }
}
