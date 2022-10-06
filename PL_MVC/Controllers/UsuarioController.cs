using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult GetAll() // ActionMethod: Métodos que  tenemos en el controlador
        {
            ML.Usuario usuario = new ML.Usuario();

            ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
            var result = obj.GetAll();
            //ML.Result result = BL.Usuario.GetAllEF();

            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error en la busqueda" + result.ErrorMessage;
                return View("Modal");
            }
            return View(usuario); //ACTION RESULT: Tipos de retorno EJEMPLO: ActionResult -> Vista en HTML
        }

        [HttpGet]
        public ActionResult Form(int? Id_Usuario)
        {

            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
            ML.Result resultRol = BL.Rol.GetAllEF();
            ML.Result resultPais = BL.Pais.GetAllEF();
            

            if (resultRol.Correct && resultPais.Correct) {

                if (Id_Usuario == null)
                {
                    
                    usuario.Rol.Rols = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;                    
                    return View(usuario);

                }
                else
                {

                    //ML.Result result = BL.Usuario.GetByIdEF(Id_Usuario.Value);
                    ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
                    var result = obj.GetById(Id_Usuario.Value);
                    

                    if (result.Correct)
                    {
                        usuario = (ML.Usuario)result.Objetc;
                        ML.Result resultEstado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                        ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                        ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                        usuario.Rol.Rols = resultRol.Objects;
                        usuario.Direccion.Colonia.Colonias = resultColonia.Objects;
                        usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;
                        usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;                        
                        return View(usuario);

                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrio un error en la busqueda" + result.ErrorMessage;
                        return View("Modal");
                    }

                }
                
            }

            return View(usuario);

        }

        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {                   


            if (usuario.Id_Usuario == 0)
            {
                
                //ML.Result result = BL.Usuario.AddEF(usuario);
                ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
                var result = obj.Add(usuario);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Registro existoso";
                    return View("Modal");
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.ErrorMessage;
                    return View("Modal");
                }

            }
            else
            {

                //ML.Result result = BL.Usuario.UpdateEF(usuario);
                ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
                var result = obj.Update(usuario);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Actualizacion existosa";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.ErrorMessage;

                }
            }

            return View("Modal");

        }

        [HttpGet]
        public ActionResult Delete(int? Id_Usuario) {

            ML.Usuario usuario = new ML.Usuario();

            if (Id_Usuario == 0)
            {

                ViewBag.Mensaje = "Ocurrio un problema al buscar el usuario";
                return View("Modal");

            }
            else
            {

                //ML.Result result = BL.Usuario.DeleteEF(Id_Usuario.Value);
                ServiceReferenceUsuario.UsuarioClient obj = new ServiceReferenceUsuario.UsuarioClient();
                var result = obj.Delete(Id_Usuario.Value);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se elimino el usuario" + result.ErrorMessage;
                    return View("Modal");

                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.ErrorMessage;
                    return View("Modal");
                }


            }

        }

        public JsonResult EstadoGetByIdPais(int IdPais) {

            ML.Result result = BL.Estado.GetByIdPais(IdPais);

            return Json(result.Objects,JsonRequestBehavior.AllowGet);
        }

        public JsonResult MunicipioGetByIdEstado(int IdEstado)
        {

            ML.Result result = BL.Municipio.GetByIdEstado(IdEstado);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)
        {

            ML.Result result = BL.Colonia.GetByIdMunicipio(IdMunicipio);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

    }
}