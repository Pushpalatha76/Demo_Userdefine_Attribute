using System;
using System.Text;

namespace Demo_Userdefined_Attribute
{
    [Author_Attribute("P.Hanselman")]

    class Program
    {
        [Author_Attribute("john")]
        static void Main(string[] args)
        {
            Console.WriteLine("Demo user define Attributes....!");
            Author_Attribute A1 = new Author_Attribute("Singh");
            Console.WriteLine("By Default version of the Author : {0}", A1.version_name);
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Method)
        ]
    public class Author_Attribute : System.Attribute
    {
        private string AuthorName;
        public Double version_name;

        public Author_Attribute(string name)
        {
            this.AuthorName = name;
            version_name = 5.0;
            Console.WriteLine("Name of the author is {0}", AuthorName);
        }
    }
}
