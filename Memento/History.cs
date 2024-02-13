namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<EditorState> states = new();
        public void push(EditorState state){
            states.Push(state);
        }
        public EditorState pop(){
            return states.Pop();
        }


    }
}