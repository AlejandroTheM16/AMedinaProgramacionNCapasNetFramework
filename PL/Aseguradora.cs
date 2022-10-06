using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingresa el nombre de la aseguradora:");
            aseguradora.Nombre = Console.ReadLine();
            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el Id de usuario correspondiente: ");
            aseguradora.Usuario.Id_Usuario = int.Parse(Console.ReadLine());            

            ML.Result result = BL.Aseguradora.AddEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("-Aseguradora agregada correctamente-");
            }
            else
            {

                Console.WriteLine("¡Ocurrio un error en la insercion! " + result.Message);
            }


        }

        public static void GetAll()
        {

            ML.Result result = BL.Aseguradora.GetAllEF();


            if (result.Correct)
            {
                Console.WriteLine("-Mostrando aseguradoras-\n");

                foreach (ML.Aseguradora aseguradora in result.Objects)
                {

                    Console.WriteLine("Id de aseguradora: " + aseguradora.IdAseguradora);
                    Console.WriteLine("Nombre: " + aseguradora.Nombre);
                    Console.WriteLine("Fecha de cracion: " + aseguradora.FechaCreacion);
                    Console.WriteLine("Fecha de modificacion: " + aseguradora.FechaModificacion);
                    Console.WriteLine("Id de usuario: " + aseguradora.Usuario.Id_Usuario);
                    Console.WriteLine("---------------------");
                }
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion " + result.Message);
            }
        }

        public static void Update()
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingresa el ID de la aseguradora a modificar:");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de la aseguradora:");
            aseguradora.Nombre = Console.ReadLine();
            //aseguradora.Usuario = new ML.Usuario();
            //Console.WriteLine("Ingresa ID de usuario correspondiente:");
            //aseguradora.Usuario.Id_Usuario = int.Parse(Console.ReadLine());


            ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("\n--Se actualizaron los datos del usuario--\n");
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion! " + result.Message);
            }


        }

        public static void GetById()
        {


            Console.WriteLine("Ingrese el ID de la aseguradora que desea consultar");
            int IdAseguradora = int.Parse(Console.ReadLine());
            ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora);

            if (result.Correct)
            {

                foreach (ML.Aseguradora aseguradora in result.Objects)
                {

                    Console.WriteLine("Mostrando informacion de aseguradora con el ID: " + IdAseguradora);
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Nombre: " + aseguradora.Nombre);
                    Console.WriteLine("Fecha de creacion: " + aseguradora.FechaCreacion);
                    Console.WriteLine("Fecha de modificacion: " + aseguradora.FechaModificacion);
                    Console.WriteLine("Id de usuario: " + aseguradora.Usuario.Id_Usuario);
                    Console.WriteLine("-------------------------------------------");
                }

            }
            else
            {
                Console.WriteLine("Ocurrio un error en la operacion " + result.Message);
            }
        }

        public static void Delete()
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Ingresa el ID de la aseguradora a eliminar:");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());


            ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("--Aseguradora eliminada correctamente--");
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion! " + result.Message);
            }

        }

    }
}
