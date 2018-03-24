using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_Tortuga
{
     abstract class Carrera
    {
        public Random rt = new Random();//para los aleatorios
        private static int _pasos = 0; //los pasos
        public int pasos = _pasos;
        protected static int _posision = 0;
        public int posision = _posision;

        public abstract int Run(); //con este se indica la accion de la carrera para cada animal, por eso es abstracta
    }
}
