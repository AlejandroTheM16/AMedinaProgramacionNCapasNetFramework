using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        public ActionResult GetAll() // ActionMethod: Métodos que  tenemos en el controlador
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            ML.Result result = BL.Aseguradora.GetAllEF();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error en la busqueda" + result.Message;
                return View("Modal");
            }
            return View(aseguradora); //ACTION RESULT: Tipos de retorno EJEMPLO: ActionResult -> Vista en HTML
        }

        [HttpGet]
        public ActionResult Form(int? IdAseguradora)
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();

            aseguradora.Usuario = new ML.Usuario();

            ML.Result resultUsuario = BL.Usuario.GetAllEF();


            if (IdAseguradora == null)
                {

                
                   aseguradora.Usuario.Usuarios = resultUsuario.Objects;                    
                    return View(aseguradora);

                }
                else
                {

                    ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);

                    if (result.Correct)
                    {
                        aseguradora = (ML.Aseguradora)result.Object;
                    aseguradora.Usuario.Usuarios = resultUsuario.Objects;                   
                    
                    //usuario.Rol.Rols = resultRol.Objects;
                    return View(aseguradora);

                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrio un error en la busqueda" + result.Message;
                        return View("Modal");
                    }

                }          
                           

        }

        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {

            //usuario.Rol = new ML.Rol();           


            if (aseguradora.IdAseguradora == 0)
            {

                ML.Result result = BL.Aseguradora.AddEF(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Registro existoso";
                    return View("Modal");
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.Message;
                    return View("Modal");
                }

            }
            else
            {

                ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Actualizacion existosa";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.Message;

                }
            }

            return View("Modal");

        }

        [HttpGet]
        public ActionResult Delete(ML.Aseguradora aseguradora)
        {

            //ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (aseguradora == null)
            {

                ViewBag.Mensaje = "No se encontro la aseguradora";
                return View("Modal");

            }
            else
            {

                ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se elimino la aseguradora" + result.Message;
                    return View("Modal");

                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.Message;
                    return View("Modal");
                }


            }

        }
    }
}