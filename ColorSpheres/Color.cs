using System;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;
        private const byte DEFAULT_ALPHA = 255;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = DEFAULT_ALPHA;
        }

        public byte GetRed() => red;

        public byte GetBlue() => blue;

        public byte GetGreen() => green;

        public byte GetAlpha() => alpha;

        public byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }

        public override string ToString()
        {
            return $"Color(R:{red}, G:{green}, B:{blue}, A:{alpha}, Grey:{GetGrey()})";
        }
    }
}