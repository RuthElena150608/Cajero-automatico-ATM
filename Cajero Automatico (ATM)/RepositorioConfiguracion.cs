using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public sealed  class RepositorioConfiguracion
    {
        public static RepositorioConfiguracion Instancia { get; } = new RepositorioConfiguracion();

        public ModosDeDispensacion modoDeDispensacion { get; set; }
        public RepositorioConfiguracion() { }

    }
}
