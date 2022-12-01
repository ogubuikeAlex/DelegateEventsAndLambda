namespace DelegateEventsAndLambda
{
    internal class UsingFuncBuiltInDelegates
    {

        //Func
        //Action
        //Predicate

        public delegate int MimicFunc(int number, string month, int count);
        public static void Run()
        {
            MimicFunc mimicFunc = MethodA;

            Func<int, string, int, int> func = MethodA;
            func += MethodC;
            func += MethodB;

            //func.Invoke(12, "54", 37);
            func(12, "54", 37);            
        }

        public static int MethodA(int number, string month, int count)
        {
            Console.WriteLine("In A");
            return number;
        }

        public static int MethodB(int number, string month, int count)
        {
            Console.WriteLine("In B");

            return number;
        }

        public static int MethodC(int number, string month, int count)
        {
            Console.WriteLine("In C");

            return number;
        }
    }
    internal class UsingActionBuiltInDelegates
    {
        public static void Run()
        {
            Action<int, bool, int, bool, string, List<int>, string[], int, bool, int, bool, string, List<int>, string[], long, decimal> OverLoadedAction = MethodA;

            Action action = MethodB;
        }

        static void MethodA(int a, bool b, int c, bool d, string e, List<int> f, string[] g, int h, bool i, int j, bool k, string l, List<int> m, string[] n, long o, decimal p)
        {

        }

        static void MethodB()
        {

        }
    }
    internal class UsingPredicateBuiltInDelegates
    {
        public static void Run()
        {
            Predicate<int> OverLoadedAction = MethodA;            
        }

        static bool MethodA(int a)
        {
            return true;
        }

        static void MethodB()
        {

        }


    }
}
