using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public class Menu
    {
        public void init()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("CAJERO AUTOMATICO (ATM) RUTH");
                Console.WriteLine("Opciones\n\t1. Configurar modo de dispensación del cajero.\n\t2. Retirar Dinero.");

                Console.Write("Selecciona una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion) {
                    case 1:
                        MenuModoDeDispensacion menuDisp = new MenuModoDeDispensacion();
                        menuDisp.elegirModoDeDispensacion();
                        break;
                    case 2:
                        RetirarDinero retirarDinero = new RetirarDinero();
                        retirarDinero.Retirar();
                        break;
                 }
            } while (opcion != 1 || opcion != 2);

            Console.ReadKey();
            
        }
    }
}
