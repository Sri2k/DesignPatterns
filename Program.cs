using DesignPatterns.Memento;

internal class Program
{
    private static void Main(string[] args)
    {
        Editor editor = new();
        editor.Content = "Damn";
        editor.Content = "DamnAgain";
        editor.Content = "enough";
        editor.Undo();
        Console.WriteLine($"Current Content {editor.Content}");
    }
}