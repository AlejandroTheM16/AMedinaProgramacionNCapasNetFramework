﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Operaciones" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Operaciones.svc or Operaciones.svc.cs at the Solution Explorer and start debugging.
    public class Operaciones : IOperaciones
    {
        public void DoWork()
        {


        }

        public string Saludar(string Nombre)
        {
            return "Hola " + Nombre + " Salu2";
        }

        public int Suma(int numero1, int numero2)
        {            
            return numero1 + numero2;
        }

        public int Resta(int numero1, int numero2)
        {

            return numero1 - numero2;
        }

        public int Multiplicacion(int numero1, int numero2)
        { 
        
            return numero1 * numero2;
        }

        public double Division(double numero1, double numero2) { 
        
            return numero1 / numero2;
        }

    }
}
