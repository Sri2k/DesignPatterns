namespace DesignPatterns.Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public EditorState CreateState()
        {
            return new(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

    }
}