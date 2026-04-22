using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private int raio;
        private int countThrown;
        
        public Sphere(Color color, int raio)
        {
            this.color = color;
            this.raio = raio;
            countThrown = 0;
        }
    }
}