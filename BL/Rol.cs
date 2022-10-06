using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
        public static ML.Result GetAllEF()

        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var roles = context.RolGetAll().ToList();

                    result.Objects = new List<object>();


                    if (roles != null)
                    {

                        foreach (var objRol in roles)
                        {
                            ML.Rol rol = new ML.Rol();

                            rol.IdRol = objRol.IdRol;
                            rol.Nombre = objRol.Nombre; 
                            

                            result.Objects.Add(rol);

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
