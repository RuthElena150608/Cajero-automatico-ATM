using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico__ATM_
{
    class ModoEficiente : MModoDeDispencion
    {
        new bool esElMontoCorrecto()
        {
            if (Monto % 200 == 0 || Monto % 1000 == 0 || Monto % 500 == 0 || Monto % 100 == 0) return true;
            return false;
        }

        public ModoEficiente() { }
        public ModoEficiente(int monto) : base(monto)
        {

            Monto = monto;
        }

        public override void entregar()
        {
            string mensaje_salida = "";

            int papeletasDe200 = 0, papeletasDe1000 = 0, papeletasDe100 = 0, papeletasDe500 = 0;

            if (esElMontoCorrecto())
            {
                while (Monto > 0)
                {

                    if (Monto >= 1000)
                    {
                        papeletasDe1000++;
                        Monto -= 1000;
                    }
                    else if (Monto >= 500)
                    {
                        papeletasDe500++;
                        Monto -= 500;
                    }
                    else if (Monto >= 200)
                    {
                        papeletasDe200++;
                        Monto -= 200;
                    }
                    else if (Monto >= 100)
                    {
                        papeletasDe100++;
                        Monto -= 100;
                    }
                }

                mensaje_salida = "Ha recibido ";

                if (papeletasDe1000 > 0)
                {
                    mensaje_salida += $"{papeletasDe1000} de 1000";
                }
                if (papeletasDe500 > 0)
                {
                    mensaje_salida += $" {papeletasDe500} de 500";

                }
                if (papeletasDe200 > 0)
                {
                    mensaje_salida += $" {papeletasDe200} de 200";
                }
                if (papeletasDe100 > 0)
                {
                    mensaje_salida += $" {papeletasDe100} de 100.";
                }
            }
            else mensaje_salida = "No se puede retirar";

            Console.WriteLine(mensaje_salida);
            Console.ReadKey();
        }



    }
}
