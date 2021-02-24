using System;

namespace language_basic
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class Author : Attribute
    {
        public readonly double Version;
        private string name;

        public Author(string name)
        {
            this.name = name;
            Version = 1.0;
        }

        public string GetName => name;
    }

    [Author("yizhou")]
    public class FirstClass
    {
    }

    [Author("wang")]
    public class SecondClass
    {
    }

    class TestAuthorAttribute
    {
        static void test()
        {
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
        }

        private static void PrintAuthorInfo(Type t)
        {
            Console.WriteLine("Author info for {0}", t);

            Attribute[] attrs = Attribute.GetCustomAttributes(t);

            foreach (Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author) attr;
                    Console.WriteLine("{0}, version is {1:f}", a.GetName, a.Version);
                }
            }
        }

        public static void Main()
        {
            test();
        }
    }
}