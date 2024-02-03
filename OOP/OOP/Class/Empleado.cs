using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class Empleado : MiembroDeLaComunicad
    {

        public DateTime? Horario { get; set; }
        public String? Posicion { get; set; }
        public decimal? Salario { get; set; }

      
        public override void save()
        {
            throw new NotImplementedException();
        }
    }
}
