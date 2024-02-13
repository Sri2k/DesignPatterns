namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreadSheet Updated");
        }
    }
}