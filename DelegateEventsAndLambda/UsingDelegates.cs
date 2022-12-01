namespace DelegateEventsAndLambda
{
    public delegate bool CustomDelegate(string name, int age);

    internal class UsingDelegates
    {
        static CustomDelegate customDelegate;

        public static void AddMethod (CustomDelegate del)
        {
            customDelegate += del;
        }

        public static void RemoveMethod(CustomDelegate del)
        {
            customDelegate -= del;
        }

        public static void Run()
        {
            customDelegate("Weeeeee", 56);
        }
    }

    public class UsingCustomDelegate
    {
        public static void Run()
        {
            //Method One 
            CustomDelegate delTwo = new CustomDelegate(MethodB);
            UsingDelegates.AddMethod(delTwo);
            //Method Two
            UsingDelegates.AddMethod(MethodA); 
            UsingDelegates.AddMethod(MethodC);

            UsingDelegates.RemoveMethod(MethodA);           

        }

        public static bool MethodB(string name, int age)
        {
            Console.WriteLine("I am inside Method B");
            return false;
        }

        public static bool MethodC(string name, int age)
        {
            Console.WriteLine("I am inside Method C");
            return true;
        }

        public static bool MethodA(string name, int age)
        {
            Console.WriteLine("I am inside Method A");
            if (name.Length != age)
            {
                return false;
            }

            return true;
        }
    }
}
