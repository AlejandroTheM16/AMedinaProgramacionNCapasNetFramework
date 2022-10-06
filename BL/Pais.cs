using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pais
    {
        public static ML.Result GetAllEF()

        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var paises = context.PaisGetAll().ToList();

                    result.Objects = new List<object>();


                    if (paises != null)
                    {

                        foreach (var objPais in paises)
                        {
                            ML.Pais pais = new ML.Pais();

                            pais.IdPais = objPais.IdPais;
                            pais.Nombre = objPais.Nombre;

                            result.Objects.Add(pais);

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
    }
}
