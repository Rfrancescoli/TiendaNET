using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    class EUsuario
    {
        public int idusuario { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string email { get; set; }
        public string calveacceso { get; set; }
        public string nivelAcceso { get; set; }
    }
}
