namespace DelegateEventsAndLambda.Laptop
{
    internal class Subscriber
    {
        public static void Run()
        {
            //Step Two
            Laptop laptop = new();
            laptop.AddClickMethod(HandleClick);
            laptop.AddAlertLowBatteryMethod(HandleLowBattery);
            laptop.AddShutdownMethod(HandleShutDown);

            laptop.Start("ASDFGIOASDFG");
        }

        //Step One
        static void HandleClick(string key)
        {
            Console.WriteLine($"The key:{key} was clicked");
        }

        static void HandleLowBattery(string message)
        {
            Console.WriteLine(message);
        }

        static void HandleShutDown(string message)
        {
            Console.WriteLine(message);
        }


    }
}
