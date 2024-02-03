using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal abstract class Docente : Empleado

    {
        public string? DocentesDisponibles { get; set; }
        public override void save()
        {
            throw new NotImplementedException();
        }
        
    }
}

