namespace DelegateEventsAndLambda.Laptop
{
    internal class Publisher
    {

    }

    public class Laptop
    {
        List<char> Keys = new() { 'A', 'S', 'D', 'F', 'G', 'I', 'O'};

        int _batteryLevel = 8;

        //click
        //sleep
        //off

        //Step One : Declare events
        event Action<string> Click;
        event Action<string> AlertLowBattery;
        event Action<string> ShutDown;

        //Step Four
        public void AddClickMethod(Action<string> method)
        {
            Click += method;
        }

        public void AddAlertLowBatteryMethod(Action<string> method)
        {
            AlertLowBattery += method;
        }

        public void AddShutdownMethod(Action<string> method)
        {
            ShutDown += method;
        }

        //Step-Extra: Constant
        const int Frequency = 1000;
        const int Duration = 500;
        const int LowBatteryLevel = 4;
        const int ShutdownBatteryLevel = 0;


        //Step Three
        public void Start(string message)
        {
            foreach (var character in message)
            {
                if (_batteryLevel < LowBatteryLevel)
                {
                    //Low Battery
                    OnAlertLowBattery("Battery Low\nPlug in laptop");
                }

                if (_batteryLevel == ShutdownBatteryLevel)
                {
                    //Shutdown
                    OnShutDown("Bye-Bye");
                    Console.Beep(Frequency, Duration);
                    return;
                }

                switch (character)
                {
                    case 'A':
                        OnClick("A");
                        break;
                    case 'S':
                        OnClick("S");
                        break;
                    case 'D':
                        OnClick("D");
                        break;
                    case 'F':
                        OnClick("F");
                        break;
                    case 'G':
                        OnClick("G");
                        break;
                    case 'I':
                        OnClick("I");
                        break;
                    case 'O':
                        OnClick("O");
                        break;
                    default:
                        _batteryLevel--;
                        continue;
                }
            }
        }

        //Step Two: Declared Event Invokers
        protected virtual void OnClick(string key)
        {
            _batteryLevel--;
            Click?.Invoke(key);
        }

        protected virtual void OnAlertLowBattery(string message)
        {
            AlertLowBattery?.Invoke(message);
        }

        protected virtual void OnShutDown(string message)
        {
            ShutDown?.Invoke(message);
        }
    }
}
