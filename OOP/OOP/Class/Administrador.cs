using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    internal class Administrador : Docente
    {

        public string? Encargado { get; set; }
        public override void save()
        {
            throw new NotImplementedException();
        }
    }
}
