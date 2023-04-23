using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO
{
        abstract class Forma
    {
        public double area { get; set; }

        public int perimetro { get; set; }

        public virtual void CalcularArea() { }


        public virtual void CalcularPerimetro() { }
        
    }


}

