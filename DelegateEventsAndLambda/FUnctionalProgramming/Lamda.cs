namespace DelegateEventsAndLambda.FUnctionalProgramming
{
    internal class Lamda
    {
        public void RUn()
        {
            Action<string, string> action =
                (string lastName, string firstName) => Console.WriteLine($"{lastName} {firstName}");

            Action<string, string> actionWithAnnonymousMethod =
                delegate (string lastName, string firstName)
                {
                    Console.WriteLine($"{lastName} {firstName}");
                };
            Action<string, string> actionWithoutAnnonymousMethod = MethodA;

            //Lamda Without Parameters
            Func<int> func = () => 2;

            Func<int> func2 = delegate ()
            {
                return 0;
            };

            Func<int> func3 = MethodB;
        }

        public void MethodA(string lastName, string firstName)
        {
            Console.WriteLine($"{lastName} {firstName}");
        }

        public int MethodB()
        {
           return 24;
        }
    }
}
