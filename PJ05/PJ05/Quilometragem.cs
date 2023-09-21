using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ05
{
    internal class Quilometragem
    {
        //atributos
        private double mm;
        private double km;


        //metodos 
        public void setMilhas(double p)
        {
            mm = p;
        }


        public double getMilhas()
        {
            return mm;
        }

        public double getQuilometros()
        {
            return km;
        }


        public void calcularQuilometros()
        {
            km = (mm * 1.852);
        }
    }
}

