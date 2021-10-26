using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_E2
{
    class calificaciones
    {
        string carnet;
        string materia;
        double[] periodo= new double [3];

        public string Carnet { get => carnet; set => carnet = value; }
        public string Materia { get => materia; set => materia = value; }
        public double[] Periodo { get => periodo; set => periodo = value; }
    }
}
