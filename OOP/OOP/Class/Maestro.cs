using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class Maestro : Docente
    {
        public string? MateriasImpartidas { get; set; }
        public string? Tiempodedocente { get; set; }
        public override void save()
        {
            throw new NotImplementedException();
        }

    }
}
