namespace DelegateEventsAndLambda.FUnctionalProgramming;

public class Sample
{
    public void MethodA()
    {

    }

    public void MethodB()
    {

    }
}

public class ApplicationTwo
{
    public static void Run()
    {
        Sample sample = new();

        sample.MethodA();
        sample.MethodB();
        sample.MethodC("Alexa");

        string month = "Detty Decembero";
        month.MethodD("Goodness and Mercy");
    }
}

public static class ExtendSample
{
    public static void MethodC(this Sample sample, string name)
    {
        Console.WriteLine(name);
    }

    public static void MethodD(this string sample, string name)
    {
        if (sample.EndsWith('o'))
        {
            Console.WriteLine(name.Length);
            return;
        }

        Console.WriteLine(name);
    }
}
