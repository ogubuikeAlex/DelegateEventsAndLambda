using System.Text;

namespace DelegateEventsAndLambda
{
    internal class DelegateReturnTypes
    {
        static StringBuilder StringB { get; set; } = new StringBuilder();
        delegate int Mydelegate(int m, int n);

        public static void Run()
        {
            //Declaration
            Mydelegate mydelegate = new Mydelegate(Add);
            //Add Methods            
            mydelegate += Subtract;
            mydelegate += Multiply;
            //Invoke
            // int result = mydelegate(45, 46);
            /* for (int i = 0; i < 3; i++)
             {*/
            mydelegate.Invoke(45, 46);
            // Console.WriteLine(result);
            //}
            Console.WriteLine(StringB.ToString());
        }

        public void Anything(int result)
        {
            int addResult = Add(45, 46);
            int subtractResult = Subtract(45, 46);

        }
        // Anything();
        public static int Add(int numOne, int numTwo)
        {
            // Console.WriteLine(numOne+numTwo);
            int num = numOne + numTwo;
            StringB.Append($"Add:{num}\n");
            return num;
        }
        public static int Subtract(int numOne, int numTwo)
        {
            StringB.Append($"Subtract:{numOne - numTwo}\n");
            return (numOne - numTwo);
        }
        public static int Multiply(int numOne, int numTwo)
        {
            StringB.Append($"Multiply:{numOne * numTwo}\n");
            return (numOne * numTwo);
        }
    }
}
