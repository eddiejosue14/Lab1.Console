using Lab1.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, pito");

            Ilogger logger = new Person();

            /*Person objPerson = new Person();
            objPerson.Id = 1;
            objPerson.Name = "Juan";
            objPerson.LastName = "Perez";
            */

            Person objPerson = new Person
            {
                Id = 1,
                Name = "Juan",
                LastName = "Perez"
            };

           /* for (int i = 0; i < 0; i++)
            {
                System.Console.WriteLine("i");
            }
            */

            string personString = string.Format("Id:{0}, Name:{1}, LastName:{2}" , objPerson.Id, objPerson.Name, objPerson.LastName);

       
            System.Console.WriteLine(personString);

            logger.Log("Meeeh");

            System.Console.ReadKey();
        }

        public void Log(String log)
        {
            System.Console.WriteLine("I need an easy friend");
        }
            
        }
    }

