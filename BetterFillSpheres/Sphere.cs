namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color Color { get; private set; }
        public float Radius { get; private set; }
        public uint TimesThrown { get; private set; } = 0;
        
        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        public void Pop() => Radius = 0;
        
        public void Throw() => TimesThrown = Radius > 0 ? TimesThrown + 1 : TimesThrown;

        public override string ToString() => $"color:({Color}), radius:{Radius}, times thrown:{TimesThrown}";
    }
}