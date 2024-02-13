using DesignPatterns.Memento;

internal class Program
{
    private static void Main(string[] args)
    {
        Editor editor = new();
        History history = new();
        editor.Content = "Damn";
        history.push(editor.CreateState());

        editor.Content = "DamnAgain";
        history.push(editor.CreateState());

        editor.Content = "enough";
        editor.Restore(history.pop());
        editor.Restore(history.pop());

        Console.WriteLine($"Current Content {editor.Content}");

    }
}