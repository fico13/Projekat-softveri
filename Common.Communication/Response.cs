using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public string Poruka { get; set; }
        public object ResponseObject { get; set; }
        public bool Uspesno { get; set; } = true;
    }
}
