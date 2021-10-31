using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    public class ModoDe100y500 : MModoDeDispencion
    {
        new bool  esElMontoCorrecto()
        {
            if (Monto % 100 == 0 || Monto % 500 == 0) return true;
            return false;
        }
        public ModoDe100y500() { }
        public ModoDe100y500(int monto) : base(monto)
        {

            Monto = monto;
        }
        public override void entregar()
        {
            string mensaje_salida = "";

            int papeletasDe500 = 0, papeletasDe100 = 0;
            if (esElMontoCorrecto())
            {
                while (Monto > 0)
                {
                    if (Monto >= 500)
                    {
                        papeletasDe500++;
                        Monto -= 500;
                    }
                    else if (Monto >= 100)
                    {
                        papeletasDe100++;
                        Monto -= 100;
                    }
                }


                if (papeletasDe100 > 0 && papeletasDe500 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe500} de 500 y {papeletasDe100} de 100";
                }
                else if (papeletasDe100 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe100} de 100";
                }
                else if (papeletasDe500 > 0)
                {
                    mensaje_salida = $"Ha recibido {papeletasDe500} de 500";
                }
            }
            else mensaje_salida = "La cantidad no coincide con el modo";

            Console.WriteLine(mensaje_salida);
            Console.ReadKey();
        }

    }
}
