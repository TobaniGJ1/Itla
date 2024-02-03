using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class Estudiante : MiembroDeLaComunicad
    {
        public String? Materias { get; set; }

        public override void save()
        {
            throw new NotImplementedException();
        }
    }
}
