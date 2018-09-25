using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana3
{
    class Credito: Cuenta
    {
        public decimal creditoSaldo { get; set; }

        public override string GetSummary()
        {
            return base.GetSummary() + "CRE: " + creditoSaldo;
        }
    }
}
