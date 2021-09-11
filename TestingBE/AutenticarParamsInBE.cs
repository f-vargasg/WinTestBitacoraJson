using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNVal.Sab.BE.CyLiq
{
    public class AutenticarParamsInBE 
    {
        public string __type { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return "[__type: " + __type + " - UserName: " + this.UserName +
                    " - Password: " + this.Password + "]";
        }

    }
}
