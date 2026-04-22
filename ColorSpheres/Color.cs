using System;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

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
            alpha = 255;
        }

        public byte GetRed() => red;

        public byte GetBlue() => blue;

        public byte GetGreen() => green;

        public byte GetAlpha() => alpha;

        public byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}