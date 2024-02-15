namespace DesignPatterns.Prototype
{
    public class ContextMenu
    {
        public void Duplicate(Component component){
           if(component is Circle) {
              Circle source = (Circle)component;
              Circle target = new Circle();
              target.Radius = source.Radius;
              // Add target to your Document/Note Pad/Paint Screen
           }
        }
    }
}
