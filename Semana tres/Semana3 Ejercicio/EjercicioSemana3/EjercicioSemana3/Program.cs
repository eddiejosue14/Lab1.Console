using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSemana3
{
    class Program
    {
        static void Main(string[] args)
        {

            Credito credito = new Credito();
            Debito debito = new Debito();

            Boolean continuar = true; 

          //Console.WriteLine("Ingrese el tipo de cuenta con la que desea trabajar. ( CRE / DEB");
          //  String tipo = Console.ReadLine();

          //  if (tipo == "CRE")
          //  {
          //      while (continuar)
          //      {
          //          Console.WriteLine("Ingrese 1 si desea ver saldos");
          //          string accion =  Console.ReadLine();

                    
          //      }
          //  }
            

            string x = Console.ReadLine();
            decimal monto = decimal.Parse(x); 

            
        }
    }
}
