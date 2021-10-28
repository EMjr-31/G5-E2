using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_E2
{
    class alumno
    {
        string carnet;
        string nombres;
        DateTime fecha;
        string correo;
        string responsable;

        public string Carnet { get => carnet;
            set {
                carnet = value;
                if (carnet == "")
                {
                    throw new Exception("Ingrese el carnet del alumno");
                }
            }
        }
        public string Nombres { get => nombres;
            set
            {
                nombres = value;
                if (value == "")
                {
                    throw new Exception("Ingrese el nombre completo del alumno");
                }
            }
        }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Correo { get => correo;
            set
            {
                correo = value;
                if (correo == "")
                {
                    throw new Exception("Ingrese el  correo del alumno");
                }
            }
        }
        public string Responsable { get => responsable;
            set
            {
                responsable = value;
                if (responsable == "")
                {
                    throw new Exception("Ingrese el nombre del responsable del alumno");
                }
            }
        }
    }

   
}
