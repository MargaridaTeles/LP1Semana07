using System;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private Color Color { get; }
        public float Raio { get; private set; }
        public int countThrown { get; private set; }
        private const float POPPED_RADIUS = 0f;
        
        public Sphere(Color color, float raio)
        {
            Color = color;
            Raio = raio;
            countThrown = 0;
        }

        public void Pop()
        {
            Raio = POPPED_RADIUS;
        }

        public void Throw()
        {
            if (Raio > 0)
                countThrown++;
        }

        public override string ToString()
        {
            return $"Sphere(Radius:{Raio}, CountThrown:{countThrown}, {Color})";
        }
    }
}