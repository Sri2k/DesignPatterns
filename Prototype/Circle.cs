namespace DesignPatterns.Prototype
{
    public class Circle : Component
    {
        public int Radius { get; set; }
        public void render()
        {
            Console.WriteLine("New Circle Object created");
        }
    }
}
