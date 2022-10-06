using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add() {

            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el nombre del usuario:");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido paterno del usuario:");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido materno del usuario:");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el genero del usuario:");
            usuario.Genero = (Console.ReadLine());
            Console.WriteLine("Ingresa el Correo del usuario:");
            usuario.Correo = Console.ReadLine();
            Console.WriteLine("Ingresa el Telefono del usuario:");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del usuario:");
            usuario.FechaNacimiento = Console.ReadLine();
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingresa ID de rol de usuario:");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de usuario:");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el password:");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa el CURP del usuario");
            usuario.CURP = Console.ReadLine(); 
            usuario.Direccion = new ML.Direccion();
            Console.WriteLine("Ingresa la calle:");
            usuario.Direccion.Calle = Console.ReadLine();
            Console.WriteLine("Ingresa el numero interior:");
            usuario.Direccion.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Ingresa el numero exterior:");
            usuario.Direccion.NumeroExterior = Console.ReadLine();
            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Ingresa el id de colonia:");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.Add(usuario);
            
            //ML.Result result=BL.Usuario.AddEF(usuario);

            if (result.Correct)
            {
                Console.WriteLine("-Usuario agregado correctamente-");
            }
            else {

                Console.WriteLine("¡Ocurrio un error en la insercion! "+result.ErrorMessage);
            }
            

        }

        public static void Update()
        {

            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el ID del usuario a modificar:");
            usuario.Id_Usuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre del usuario:");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido paterno del usuario:");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido materno del usuario:");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el genero del usuario:");
            usuario.Genero = Console.ReadLine();
            Console.WriteLine("Ingresa el Correo del usuario:");
            usuario.Correo = Console.ReadLine();
            Console.WriteLine("Ingresa el Telefono del usuario:");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de nacimiento del usuario:");
            usuario.FechaNacimiento = Console.ReadLine();
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingresa ID de rol de usuario:");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de usuario:");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el password:");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa el CURP:");
            usuario.CURP = Console.ReadLine();
            usuario.Direccion = new ML.Direccion();
            Console.WriteLine("Ingresa la calle:");
            usuario.Direccion.Calle = Console.ReadLine();
            Console.WriteLine("Ingresa el numero interior:");
            usuario.Direccion.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Ingresa el numero exterior:");
            usuario.Direccion.NumeroExterior = Console.ReadLine();
            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Ingresa el id de colonia:");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());


            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.Update(usuario);
            //ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("\n--Se actualizaron los datos del usuario--\n");
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion! "+result.ErrorMessage);
            }
            

        }

        public static void Delete()
        {

            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa el ID del usuario a eliminar:");
            usuario.Id_Usuario = int.Parse(Console.ReadLine());

            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.Delete(usuario.Id_Usuario);


            //ML.Result result = BL.Usuario.DeleteEF(usuario.Id_Usuario);

            if (result.Correct)
            {
                Console.WriteLine("--Usuario eliminado correctamente--");
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion! "+result.ErrorMessage);
            }          

        }

        public static void GetAll()
        {

            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.GetAll();

            //ML.Result result = BL.Usuario.GetAllEF();         


            if (result.Correct)
            {
                Console.WriteLine("-Mostrando usuarios-\n");

                foreach(ML.Usuario usuario in result.Objects){

                    Console.WriteLine("Id de usuario: "+ usuario.Id_Usuario);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Genero: " + usuario.Genero);
                    Console.WriteLine("Correo: " + usuario.Correo);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
                    //Console.WriteLine("Id de rol: " + usuario.Rol.IdRol);
                    Console.WriteLine("Rol: " + usuario.Rol.Nombre);
                    Console.WriteLine("Nombre de usuario: " + usuario.UserName);
                    Console.WriteLine("Password: " + usuario.Password);
                    Console.WriteLine("CURP: " + usuario.CURP);
                    Console.WriteLine("Status: " + usuario.Status);
                    Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                    Console.WriteLine("Numero Interior: " + usuario.Direccion.NumeroInterior);
                    Console.WriteLine("Numero exterior: " + usuario.Direccion.NumeroExterior);
                    //Console.WriteLine("IdCOlonia: " + usuario.Direccion.Colonia.IdColonia);
                    Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                    //Console.WriteLine("IdMunicipio: " + usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                    //Console.WriteLine("IdEstado: " + usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                    //Console.WriteLine("IdPais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                    Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);

                    Console.WriteLine("---------------------");

                    
                }
            }
            else
            {

                Console.WriteLine("Ocurrio un error en la operacion "+result.ErrorMessage);
            }
        }

        public static void GetById() {


            Console.WriteLine("Ingrese el ID de usuario que desea consultar");
            int Id_Usuario = int.Parse(Console.ReadLine());            
            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.GetById(Id_Usuario);
           
            //ML.Result result = BL.Usuario.GetByIdEF(Id_Usuario);
            

            if (result.Correct){

                   ML.Usuario usuario = ((ML.Usuario)result.Objetc);

                    Console.WriteLine("Mostrando informacion del usuario con el ID: " + Id_Usuario);
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Genero: " + usuario.Genero);
                    Console.WriteLine("Correo: " + usuario.Correo);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);     
                    
                    Console.WriteLine("Id de rol: " + usuario.Rol.IdRol);
                    
                    Console.WriteLine("Nombre de usuario: " + usuario.UserName);
                    Console.WriteLine("Password: " + usuario.Password);
                    Console.WriteLine("CURP: " + usuario.CURP);                   
                    Console.WriteLine("Status: " + usuario.Status);
                    
                    Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                    Console.WriteLine("Numero Interior: " + usuario.Direccion.NumeroInterior);
                    Console.WriteLine("Numero Exterior: " + usuario.Direccion.NumeroExterior);
                    
                    //Console.WriteLine("idColonia: " + usuario.Direccion.Colonia.IdColonia);
                    Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);

                    Console.WriteLine("-------------------------------------------");

                Console.ReadLine();
                

            }
            else {
                Console.WriteLine("Ocurrio un error en la operacion " + result.ErrorMessage);
            }
        }


    }
}
