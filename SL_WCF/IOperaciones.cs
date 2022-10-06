﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperaciones" in both code and config file together.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string Saludar(String Nombre);

        [OperationContract]
        int Suma(int numero1, int numero2);

        [OperationContract]
        int Resta(int numero1, int numero2);

        [OperationContract]
        int Multiplicacion(int numero1, int numero2);

        [OperationContract]
        double Division(double numero1, double numero2);


    }
}