using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Prototype Pattern
        ContextMenu context = new();
        Circle circle = new();
        context.Duplicate(circle);

        Console.WriteLine("Test");
        #endregion



        #region Observer Pattern
        // DataSource dataSource = new DataSource();

        // SpreadSheet spreadSheet1 = new();
        // SpreadSheet spreadSheet2 = new();

        // Chart chart = new();

        // dataSource.addObserver(spreadSheet1);
        // dataSource.addObserver(spreadSheet2);
        // dataSource.addObserver(chart);

        // dataSource.Value = 3;

        #endregion
        #region  Memento Pattern
        // Editor editor = new();
        // History history = new();
        // editor.Content = "Damn";
        // history.push(editor.CreateState());

        // editor.Content = "DamnAgain";
        // history.push(editor.CreateState());

        // editor.Content = "enough";
        // editor.Restore(history.pop());
        // editor.Restore(history.pop());

        // Console.WriteLine($"Current Content {editor.Content}");
        #endregion

    }
}