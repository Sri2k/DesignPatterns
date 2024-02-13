namespace DesignPatterns.Memento
{
    public class EditorState
    {
        public EditorState(string content){
            this.Content = content;
        }

        public string Content { get; }
    }
}