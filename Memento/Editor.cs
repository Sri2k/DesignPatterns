namespace DesignPatterns.Memento
{
    public class Editor
    {
        Stack<string> contentStack = new Stack<string>();
        private string content = "";
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                contentStack.Push(content);
                content = value;
            }
        }

        public void Undo()
        {
            if (contentStack != null && contentStack.Count > 0)
            {
                contentStack.Pop();
                content = contentStack.Peek();
            }
            else
            {
                Console.WriteLine("No more undo actions available.");
            }
        }
    }
}