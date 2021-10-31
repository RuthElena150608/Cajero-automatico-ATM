using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    class ModoDe200y1000 : MModoDeDispencion
    {
        new bool esElMontoCorrecto()
        {
            if (Monto % 200 == 0 || Monto % 1000 == 0) return true;
            return false;
        }

        public ModoDe200y1000() { }
        public ModoDe200y1000(int monto) : base(monto)
        {

            Monto = monto;
        }

        public override void entregar()
        {
            string mensaje_salida = "";

            int papeletasDe200 = 0, papeletasDe1000 = 0;
            if (esElMontoCorrecto())
            {
                while (Monto > 0)
                {
                    if (Monto >= 1000)
                    {
                        papeletasDe1000++;
                        Monto -= 1000;
                    }
                    else if (Monto >= 200)
                    {
                        papeletasDe200++;
                        Monto -= 200;
                    }
                }


                if (papeletasDe200 > 0 && papeletasDe1000 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe200} de 200 y {papeletasDe1000} de 1000";
                }
                else if (papeletasDe200 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe200} de 200";
                }
                else if (papeletasDe1000 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe1000} de 1000";
                }
            }
            else mensaje_salida = "No se puede retirar";

            Console.WriteLine(mensaje_salida);
            Console.ReadKey();
        }


    }
}
