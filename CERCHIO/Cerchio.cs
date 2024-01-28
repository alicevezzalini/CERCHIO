using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERCHIO
{
    internal class Cerchio
    {
        public int Raggio { get; set; }

        public Cerchio(int raggio) 
        { 
            Raggio = raggio;         
        }

        public override string ToString()
        {
            return string.Format("Cerchio R = {0}", Raggio);
        }

       
    }
}
