using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruMeObjects
{

    public class ResponseTime
    {
        public double time { get; set; }
        public string measure { get; set; }
    }

    public class InitTime
    {
        public double time { get; set; }
        public string measure { get; set; }
    }

    public class RootObject
    {
        public int code { get; set; }
        public ResponseTime response_time { get; set; }
        public InitTime init_time { get; set; }
    }

}
