using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        private int countThrown;
        private const float POPPED_RADIUS = 0f;
        
        public Sphere(Color color, float raio)
        {
            this.color = color;
            this.raio = raio;
            countThrown = 0;
        }

        public void Pop()
        {
            raio = POPPED_RADIUS;
        }

        public void Throw()
        {
            if (raio > 0)
                countThrown++;
        }

        public int GetTimesThrown() => countThrown;

        public override string ToString()
        {
            return $"Sphere(Radius:{raio}, CountThrown:{countThrown}, {color})";
        }
    }
}