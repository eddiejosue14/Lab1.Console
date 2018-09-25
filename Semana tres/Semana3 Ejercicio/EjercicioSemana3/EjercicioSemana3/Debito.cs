using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana3
{
    class Debito: Cuenta
    {
        public decimal debitoSaldo { get; set; }

        public override string GetSummary()
        {
            return base.GetSummary() + "DEB: " + debitoSaldo;

            if (debitoSaldo < 0)
            {
                Console.WriteLine("Fondos insuficientes");

                if (debitoSaldo > montoTransaccion)
                {
                    result = debitoSaldo - montoTransaccion;
                    Console.WriteLine("Transaccion realizada correctamente");
                }
            }
        }

    }
}
