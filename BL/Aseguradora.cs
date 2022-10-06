using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.AseguradoraAdd(aseguradora.Nombre,aseguradora.Usuario.Id_Usuario);


                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;

        }

        public static ML.Result GetAllEF()

        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var aseguradoras = context.AseguradoraGetAll().ToList();

                    result.Objects = new List<object>();


                    if (aseguradoras != null)
                    {

                        foreach (var obj in aseguradoras)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString("dd-MM-yyyy");
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString("dd-MM-yyyy");
                            aseguradora.Usuario.Id_Usuario = obj.Id_Usuario;

                            result.Objects.Add(aseguradora);

                        }

                        result.Correct = true;
                    }

                }

            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.AseguradoraUpdate(aseguradora.IdAseguradora,aseguradora.Nombre);


                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

        public static ML.Result GetByIdEF(int Id)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var aseguradoras = context.AseguradoraGetById(Id).FirstOrDefault();                   


                    if (aseguradoras != null)
                    {

                       
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();

                            aseguradora.Nombre = aseguradoras.Nombre;
                            aseguradora.FechaCreacion = aseguradoras.FechaCreacion.ToString("dd-MM-yyyy");
                            aseguradora.FechaModificacion = aseguradoras.FechaModificacion.ToString("dd-MM-yyyy");
                            aseguradora.Usuario.Id_Usuario = aseguradoras.Id_Usuario;

                            result.Object=aseguradora;

                        

                        result.Correct = true;
                    }

                }

            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

        public static ML.Result DeleteEF(ML.Aseguradora aseguradora)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.AseguradoraDelete(aseguradora.IdAseguradora);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }


    }

}
