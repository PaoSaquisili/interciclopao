using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInterciclo.Entities
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha { get; set; }
        public string password { get; set; }


    }
}
