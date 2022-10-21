namespace MyWebServer
{
    using System;
    using System.Threading.Tasks;

    delegate void MyDelegate(string s);
    delegate string StrDelegate(int n);
    class MyClass
    {
        public MyDelegate apply;
        public MyClass(MyDelegate md) => apply = md;
    }

    class Alpha
    {
        private string name;
        public void SetName(string s) => name = s;
        public override string ToString()
            => name;
    }
    public class Startup
    {
        public static async Task Main()
        {
            Alpha A = new Alpha();
            Action<MyDelegate> action=SomeMethod;

            action = A.SetName;

            //MyClass obj = new MyClass(A.SetName);

            //obj.apply("OOO");

            //Console.WriteLine(A);
        }

        private static string SomeStrMethod(int n)
        {
            //StrDelegate strDelegate = SomeStrMethod;

            //Console.WriteLine(strDelegate(9999));
            return n.ToString();
        }

        static void SomeMethod(string s)
        {
            //MyDelegate myDelegate = SomeMethod;

            //myDelegate("JJJJJJJJJ");
            Console.WriteLine(s);
        }
    }
}
