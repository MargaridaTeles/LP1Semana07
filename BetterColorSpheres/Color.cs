using System;

namespace BetterColorSpheres
{
    public class Color
    {
        private byte Red { get; }
        private byte Green { get; }
        private byte Blue { get; }
        private byte Alpha { get; }
        private const byte DEFAULT_ALPHA = 255;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = DEFAULT_ALPHA;
        }

        public byte Grey() => (byte)((Red + Green + Blue) / 3);

        public override string ToString()
        {
            return $"Color(R:{Red}, G:{Green}, B:{Blue}, A:{Alpha}, Grey:{Grey()})";
        }
    }
}