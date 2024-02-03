using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class ExAlumno : MiembroDeLaComunicad
    {

        public DateTime? FechaSalida {  get; set; }
        
        public DateTime? FechaGraduacion { get; set; }


        public override void save()
        {
            throw new NotImplementedException();
        }
    }
}
