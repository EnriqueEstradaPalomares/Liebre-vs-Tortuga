using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_Tortuga
{
    class Liebre : Carrera
    {
        public override int Run()//la funcion principal de Carrera, remplaza su codigo, para eso es el override
        {
            int pasos = 0;
            int velocidad = rt.Next(1, 11);
            if (velocidad <= 2)
                pasos += 0;
            if (velocidad >= 3 && velocidad <= 4)
                pasos += 9;
            if (velocidad == 5)
                pasos -= 12;
            if (velocidad >= 6 && velocidad <= 8)
                pasos += 1;
            if (velocidad > 8)
                pasos -= 2;

            return pasos;
        }
    }
}
