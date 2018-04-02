using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DeserializationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializableClass sc = new SerializableClass();

            BinaryFormatter fmt = new BinaryFormatter();
            using (FileStream stm = File.OpenRead(@"c:\temp\output.stm"))
            {
                sc = (SerializableClass)fmt.Deserialize(stm);
            }
            Console.WriteLine(sc.StringProperty);
            Console.WriteLine(sc.StringProperty);
            Console.Read();
        }
    }

    [Serializable]
    public class SerializableClass
    {
        public string StringProperty { get; set; }
        public int IntegerProperty { get; set; }
    }
}
