using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public class RetirarDinero
    {
        public void Retirar()
        {
            Console.Clear();
            int cantidad;
            Console.Write("Cantidad a retirar: ");
            int.TryParse(Console.ReadLine(), out cantidad);

            var modoDeDispencion  = getModo(cantidad);

            modoDeDispencion.entregar();
            Console.ReadKey();
        }

        MModoDeDispencion getModo(int monto)
        {
            var modo = new MModoDeDispencion();
            switch (RepositorioConfiguracion.Instancia.modoDeDispensacion)
            {
                case ModosDeDispensacion.Modo_100_500:
                    modo = new ModoDe100y500(monto);
                    break;
                case ModosDeDispensacion.Modo_200_1000:
                    modo = new ModoDe200y1000(monto);
                    break;
                case ModosDeDispensacion.ModoEficiente:
                    modo = new ModoEficiente(monto);
                    break;
            }

            return modo;
        }
    }
}
