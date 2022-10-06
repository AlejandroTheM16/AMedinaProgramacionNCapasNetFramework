using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {       
                    
          

            int opcion = 0;

            do
            { 

                Console.WriteLine("Selecciona la operacion a ejecutar:\n" +
                    "1.Add.\n" +
                    "2.Update.\n" +
                    "3.Delete.\n" +
                    "4.GetAll.\n" +
                    "5.GetById\n" +
                    "6.Salir.");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        PL.Usuario.Add();
                        break;
                    case 2:
                        PL.Usuario.Update();
                        break;
                    case 3:
                        PL.Usuario.Delete();
                        break;
                    case 4:
                        PL.Usuario.GetAll();
                        break;
                    case 5:
                        PL.Usuario.GetById();
                        break;

                }
            } while (opcion != 6);


        }
    }
}
