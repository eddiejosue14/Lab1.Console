using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana3
{
    class Cuenta
    {
        public String tipoCuenta { get; set; }
        public decimal montoTransaccion { get; set; }
        public decimal result;

        public virtual string GetSummary()
        {
            return string.Format("{0}", tipoCuenta);

           
        }



    }
}
