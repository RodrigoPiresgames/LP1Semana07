using System;
 
 namespace ColorSpheres
 {
     public class Program
     {
         private static void Main(string[] args)
         {
             Color cor1 = new Color(255,100,0);
             Color cor2 = new Color(102,0,60);
             Color cor3 = new Color(0,150,150, 152);
 
             Sphere esphera1 = new Sphere(cor1, 20);
             Sphere esphera2 = new Sphere(cor3, 100);
             Sphere esphera3 = new Sphere(cor2, 0);
 
             esphera1.Throw();
             esphera1.Throw();
             esphera1.Throw();
             Console.WriteLine(esphera1.GetTimesThrown());
             esphera1.Pop();
             esphera1.Throw();
             esphera1.Throw();
             Console.WriteLine(esphera1.GetTimesThrown());
 
             esphera3.Throw();
             esphera3.Throw();
             Console.WriteLine(esphera3.GetTimesThrown());
             
             Console.WriteLine(esphera2.GetRadius());
             Console.WriteLine(esphera2.GetColor());
             Console.WriteLine(esphera2.GetTimesThrown());
 
         }
     }
 }