using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
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
         public byte GetGreen() => green;
         public byte GetBlue() => blue;
         public byte GetAlpha() => alpha;
         public string GetColor() => $"{GetRed()},{GetGreen()},{GetBlue()},{GetAlpha()}";
 
         public byte GetGray()
         {
             return (byte)((red+green+blue)/3);
         }
    }
}