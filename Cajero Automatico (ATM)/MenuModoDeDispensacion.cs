using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public class MenuModoDeDispensacion
    {
        public void elegirModoDeDispensacion()
        {
            Console.Clear();
            Console.WriteLine("Opciones\n\t1. Papeletas  de 100 y 500\n\t2. Papeletas de 200 y 1000.\n\t3. Modo eficiente. Papeletas de 100, 200, 500 y 1000.");
            int modo;
            Console.Write("Selecciona un modo: ");

            int.TryParse(Console.ReadLine(), out modo);

            switch (modo)
            {
                case (int)ModosDeDispensacion.Modo_100_500:
                    RepositorioConfiguracion.Instancia.modoDeDispensacion = ModosDeDispensacion.Modo_100_500;
                    break;
                case (int)ModosDeDispensacion.Modo_200_1000:
                    RepositorioConfiguracion.Instancia.modoDeDispensacion = ModosDeDispensacion.Modo_200_1000;
                                        break;
                case (int)ModosDeDispensacion.ModoEficiente:
                    RepositorioConfiguracion.Instancia.modoDeDispensacion = ModosDeDispensacion.ModoEficiente;
                    break;
            }
        }
    }
}
