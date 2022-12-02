namespace DelegateEventsAndLambda.FUnctionalProgramming
{
    internal class Indexer
    {
        List<int> numbers = new List<int>()
        {
            1, 4, 6, 8, 3, 4, 6, 4, 2, 3, 2, 4, 2 
        };

        public int this[int index]
        {
            get => numbers[index];
            set => numbers[index] = value;
        }
    }

    internal class ApplicationThree
    {
        public void Run()
        {
            Indexer indexer = new();

            var number = indexer[0];
        }
    }
}
