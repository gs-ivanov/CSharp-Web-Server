namespace MyWebServer
{
    using System;
    delegate int MyDelegate(int x, int y);
    public class Startup
    {
        private static int result;
        private static string result2;
        public static void Main()
        {
            // Delegate
            MyDelegate del = new MyDelegate(AddNumbers);
            Console.WriteLine("Delegate: " + del(9, 12));

            //Func
            Func<int, int, int> Addition = AddNumbers;

            Console.WriteLine("Func: " + Addition(10, 20));

            //Func with anonymous method
            Func<int, int, int> AdditionAnonim = delegate (int a, int b) { return (a + b); };

            Console.WriteLine("Func AdditionAnonim: " + AdditionAnonim(10, 20));

            //Func with Lambda 
            //Func<int, int, int> calc =(a,b)=>{ return (a + b); };
            Func<int, int, int> calc = (a, b) => (a * b - 20000);

            Console.WriteLine("Func Lambda AdditionAnonim: " + calc(100, 200));//0

            //Action delegate
            Action<int, int> ActAddition = AddNumbersVoid;
            ActAddition(55, 45);     //100

            //Action with anonymous method
            Action<int, int> actionAnonim = delegate (int a, int b) { Console.WriteLine($"Action Anonymous: { a + b};"); };
            actionAnonim(550, 450);

            //Action Lambda
            Action<int, int> action = (a, b) => Console.WriteLine($"Action Lambda: { (a + b)};");
            action(1, 2);

            //Action Lambda
            Action<int, int> action2 = (a, b) => Console.WriteLine(a + b);

            action2(4, 2);


            //Action Lambda by book
            Action<int, int> Addition2 = (a, b) => result = a + b;
            Addition2(4000000, 2);
            Console.WriteLine(result);

            Action<int, int, string> action1 = (x, y, s) => result2 = (x + y+s.Length).ToString() + s;
            action1(12, 3, " Kooo?");
            Console.WriteLine(result2);
        }

        static int AddNumbers(int a, int b) => a + b;
        static void AddNumbersVoid(int a, int b) => Console.WriteLine($"ActionAplusB: " + (a + b));

    }
}
