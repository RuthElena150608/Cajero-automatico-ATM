using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public class MModoDeDispencion
    {
        public int Monto { get; set; }
        public MModoDeDispencion() { }
        public MModoDeDispencion(int monto)
        {

            Monto = monto;
        }
        public virtual bool esElMontoCorrecto()
        {
            return false;
        }
        public virtual void entregar() { }
    }
}
