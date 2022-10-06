﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CURP { get; set; }
        public string Imagen { get; set; }
        public bool? Status { get; set; }
        public ML.Rol Rol { get; set; }
        public List<object> Usuarios { get; set; }
        public ML.Direccion Direccion { get; set; }

        


        //Alias

        public string NombreCalle { get; set; }
        public string NombreColonia { get; set; }
        public string NombreMunicipio { get; set; }
        public string NombreEstado { get; set; }
        public string NombrePais { get; set; }
        public string NombreRol { get; set; }

    }
}
