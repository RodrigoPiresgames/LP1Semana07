using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
 
namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color cor;
        private float raio;
        private int atirado;

        public Sphere(Color cor, int raio, int atirado = 0)
        {
            this.cor = cor;
            this.raio = raio;
        }
 
        public void Pop()
        {
            raio = 0;
        }
 
        public void Throw()
        {
            if (raio > 0)
            {
                atirado++;
            }
        }
 
        public int GetTimesThrown() => atirado;
        public string GetColor() => cor.GetColor();
        public float GetRadius() => raio;
     
    }
}
