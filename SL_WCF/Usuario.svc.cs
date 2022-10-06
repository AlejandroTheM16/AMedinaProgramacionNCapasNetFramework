using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Usuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Usuario.svc or Usuario.svc.cs at the Solution Explorer and start debugging.
    public class Usuario : IUsuario
    {
        public void DoWork()
        {
        }

        

        public SL_WCF.Result GetAll() { 
        
            ML.Result resultBusiness = BL.Usuario.GetAllEF();

            return new SL_WCF.Result
            {

                Correct = resultBusiness.Correct,
                ErrorMessage = resultBusiness.Message,
                Ex = resultBusiness.Ex,
                Objetc = resultBusiness.Object,
                Objects = resultBusiness.Objects

            };
        }

        public SL_WCF.Result GetById(int Idusuario)
        {

            ML.Result resultBusiness = BL.Usuario.GetByIdEF(Idusuario);

            return new SL_WCF.Result
            {

                Correct = resultBusiness.Correct,
                ErrorMessage = resultBusiness.Message,
                Ex = resultBusiness.Ex,
                Objetc = resultBusiness.Object,              

            };
        }

        public SL_WCF.Result Add(ML.Usuario usuario) {

            ML.Result resultBusiness = BL.Usuario.AddEF(usuario);

            return new SL_WCF.Result
            {
                Correct = resultBusiness.Correct,
                ErrorMessage = resultBusiness.Message,
                Ex = resultBusiness.Ex             

            };
        }

        public SL_WCF.Result Update(ML.Usuario usuario)
        {

            ML.Result resultBusiness = BL.Usuario.UpdateEF(usuario);

            return new SL_WCF.Result
            {

                Correct = resultBusiness.Correct,
                ErrorMessage = resultBusiness.Message,
                Ex = resultBusiness.Ex

            };
        }

        public SL_WCF.Result Delete(int Idusuario)
        {
            ML.Usuario usuario= new ML.Usuario();
            usuario.Id_Usuario = Idusuario;
            ML.Result result = BL.Usuario.DeleteEF(Idusuario);

            return new Result { Correct = result.Correct, ErrorMessage = result.Message, Ex = result.Ex };
        }

    }
}
