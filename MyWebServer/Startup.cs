namespace MyWebServer
{
    using System;
    delegate int MyDelegate(int x,int y);
    public class Startup
    {
        public static void Main()
        {
            // Delegate
            MyDelegate del = new MyDelegate(AddNumbers);
            Console.WriteLine("Delegate: " + del(9,12));

            //Func
            Func<int, int, int> Addition = AddNumbers;

            Console.WriteLine("Func: " + Addition(10, 20));

            //Func with anonymous method
            Func<int, int, int> AdditionAnonim = delegate (int a, int b) { return (a + b); };

            Console.WriteLine("Func AdditionAnonim: " + AdditionAnonim(10, 20));
            
            //Func with Lambda 
            //Func<int, int, int> calc =(a,b)=>{ return (a + b); };
            Func<int, int, int> calc =(a,b)=>(a *b-20000);

            Console.WriteLine("Func AdditionAnonim: " + calc(100, 200));

        }

        static int AddNumbers(int a, int b) => a + b;
    }
}
