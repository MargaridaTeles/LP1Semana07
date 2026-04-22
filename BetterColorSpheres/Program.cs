using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0);
            Color blue = new Color(0, 0, 255, 200);

            Sphere s1 = new Sphere(red, 10f);
            Sphere s2 = new Sphere(blue, 5f);

            s1.Throw();
            s1.Throw();
            s2.Throw();

            s2.Pop();
            s2.Throw(); 

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
