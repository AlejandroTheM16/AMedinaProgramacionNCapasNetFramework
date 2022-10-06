using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario) {
            
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "INSERT INTO Usuario(Nombre,ApellidoPaterno,ApellidoMaterno,Genero,Edad,Correo,Telefono," +
                        "FechaDeRegistro,FechaDeNacimiento) VALUES (@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Genero,@Edad,@Correo,@Telefono," +
                        "@FechaDeRegistro,@FechaDeNacimiento)";
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[9];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("Genero", SqlDbType.Char);
                    collection[3].Value = usuario.Genero;
                    collection[4] = new SqlParameter("Edad", SqlDbType.Int);
                    collection[4].Value = usuario.Edad;
                    collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("FechaDeRegistro", SqlDbType.DateTime);
                    collection[7].Value = usuario.FechaRegistro;
                    collection[8] = new SqlParameter("FechaDeNacimiento", SqlDbType.DateTime);
                    collection[8].Value = usuario.FechaNacimiento;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
                    {
                       result.Correct=true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception Ex) {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }            

            return result;

        }

        public static ML.Result AddSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioAdd";
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[9];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("Genero", SqlDbType.Char);
                    collection[3].Value = usuario.Genero;
                    collection[4] = new SqlParameter("Edad", SqlDbType.Int);
                    collection[4].Value = usuario.Edad;
                    collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("FechaDeRegistro", SqlDbType.DateTime);
                    collection[7].Value = usuario.FechaRegistro;
                    collection[8] = new SqlParameter("FechaDeNacimiento", SqlDbType.DateTime);
                    collection[8].Value = usuario.FechaNacimiento;
                    collection[9] = new SqlParameter("IdRol", SqlDbType.DateTime);
                    collection[9].Value = usuario.Rol.IdRol;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
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

        public static ML.Result Update(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UPDATE [Usuario] SET[Nombre] = @Nombre,[ApellidoPaterno] = @ApellidoPaterno,[ApellidoMaterno] = @ApellidoMaterno,[Genero] = @Genero,[Edad] = @Edad,[Correo] = @Correo,[Telefono] = @Telefono,[FechaDeRegistro] = @FechaDeRegistro,[FechaDeNacimiento] = @FechaDeNacimiento " +
                        "WHERE Id_Usuario = @Id_Usuario";
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[10];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("Genero", SqlDbType.Char);
                    collection[3].Value = usuario.Genero;
                    collection[4] = new SqlParameter("Edad", SqlDbType.Int);
                    collection[4].Value = usuario.Edad;
                    collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("FechaDeRegistro", SqlDbType.DateTime);
                    collection[7].Value = usuario.FechaRegistro;
                    collection[8] = new SqlParameter("FechaDeNacimiento", SqlDbType.DateTime);
                    collection[8].Value = usuario.FechaNacimiento;
                    collection[9] = new SqlParameter("Id_Usuario", SqlDbType.Int);
                    collection[9].Value = usuario.Id_Usuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
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

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioUpdate";
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[11];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("Genero", SqlDbType.Char);
                    collection[3].Value = usuario.Genero;
                    collection[4] = new SqlParameter("Edad", SqlDbType.Int);
                    collection[4].Value = usuario.Edad;
                    collection[5] = new SqlParameter("Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("FechaDeRegistro", SqlDbType.DateTime);
                    collection[7].Value = usuario.FechaRegistro;
                    collection[8] = new SqlParameter("FechaDeNacimiento", SqlDbType.DateTime);
                    collection[8].Value = usuario.FechaNacimiento;
                    collection[9] = new SqlParameter("Id_Usuario", SqlDbType.Int);
                    collection[9].Value = usuario.Id_Usuario;
                    collection[10] = new SqlParameter("IdRol", SqlDbType.Int);
                    collection[10].Value = usuario.Rol.IdRol;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
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

        public static ML.Result Delete(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "DELETE [Usuario] WHERE Id_Usuario = @Id_Usuario";
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("Id_Usuario", SqlDbType.Int);
                    collection[0].Value = usuario.Id_Usuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
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

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioDelete";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("Id_Usuario", SqlDbType.Int);
                    collection[0].Value = usuario.Id_Usuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
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

        public static ML.Result GetAll()
        {
                        
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {
                    
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioGetAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = context;

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0) { 

                        result.Objects = new List<object>();

                        foreach (DataRow dr in dt.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol();

                            usuario.Id_Usuario = int.Parse(dr[0].ToString());
                            usuario.Nombre = dr[1].ToString();
                            usuario.ApellidoPaterno = dr[2].ToString();
                            usuario.ApellidoMaterno = dr[3].ToString();
                            usuario.Genero = dr[4].ToString();
                            usuario.Edad = int.Parse(dr[5].ToString());
                            usuario.Correo = dr[6].ToString();
                            usuario.Telefono = dr[7].ToString();
                            //usuario.FechaRegistro = DateTime.Parse(dr[8].ToString());
                            //usuario.FechaNacimiento = DateTime.Parse(dr[9].ToString());
                            //usuario.IdRol = int.Parse(dr[10].ToString());
                            usuario.Rol.IdRol = int.Parse(dr[10].ToString());

                            result.Objects.Add(usuario);

                        }

                        result.Correct = true;
                    }

                }

            }
            catch (Exception Ex)            {

                result.Correct = false;
                result.Message = Ex.Message;
                result.Ex = Ex;
            }

            return result;

        }

        public static ML.Result GetById(int IdUsuario) {

            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioGetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = context;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
                    collection[0].Value = IdUsuario;
                    cmd.Parameters.AddRange(collection);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {                    

                            DataRow dr = dt .Rows[0];   
                            ML.Usuario usuario = new ML.Usuario();                            

                            usuario.Nombre = dr[0].ToString();
                            usuario.ApellidoPaterno = dr[1].ToString();
                            usuario.ApellidoMaterno = dr[2].ToString();
                            usuario.Genero = dr[3].ToString();
                            usuario.Edad = int.Parse(dr[4].ToString());
                            usuario.Correo = dr[5].ToString();
                            usuario.Telefono = dr[6].ToString();
                            usuario.FechaRegistro = DateTime.Parse(dr[7].ToString());
                            //usuario.FechaNacimiento = DateTime.Parse(dr[8].ToString());
                            //usuario.IdRol = int.Parse(dr[10].ToString());
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = int.Parse(dr[9].ToString());           
                        
                        result.Object = usuario; 

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

        public static ML.Result GetAllEF() 
        
        {

            ML.Result result = new ML.Result();           

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var usuarios = context.UsuarioGetAllNetF().ToList();

                    result.Objects = new List<object>();


                    if (usuarios != null)
                    {

                        foreach (var obj in usuarios)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol();
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuario.Id_Usuario = obj.Id_Usuario;
                            usuario.Nombre = obj.NombreUsuario;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Genero = obj.Genero;
                            usuario.Correo = obj.Correo;
                            usuario.Telefono = obj.Telefono;
                            //usuario.FechaRegistro = obj.FechaDeRegistro.Value;
                            usuario.FechaNacimiento = obj.FechaDeNacimiento.ToString("dd-MM-yyyy");
                            //usuario.IdRol = int.Parse(dr[10].ToString());
                            usuario.Rol.IdRol = obj.IdRol;
                            usuario.Rol.Nombre = obj.NombreRol;
                            usuario.UserName = obj.UserName;
                            usuario.Password = obj.Password;    
                            usuario.CURP = obj.CURP;
                            //usuario.Status = obj.Status;
                            //usuario.Imagen = obj.Imagen.ToString();
                            
                            usuario.Direccion.Calle = obj.NombreCalle;
                            usuario.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuario.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuario.Direccion.Colonia.IdColonia = obj.IdColonia;
                            usuario.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio;
                            usuario.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;


                            result.Objects.Add(usuario);

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

        public static ML.Result GetByIdEF(int Id) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var ObjUsuario = context.UsuarioGetById(Id).FirstOrDefault();

                    if (ObjUsuario != null)
                    {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol();
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuario.Nombre = ObjUsuario.Nombre;
                            usuario.ApellidoPaterno = ObjUsuario.ApellidoPaterno;
                            usuario.ApellidoMaterno = ObjUsuario.ApellidoMaterno;
                            usuario.Genero = ObjUsuario.Genero;
                            usuario.Correo = ObjUsuario.Correo;
                            usuario.Telefono = ObjUsuario.Telefono;
                            usuario.FechaNacimiento = ObjUsuario.FechaDeNacimiento.ToString("dd-MM-yyyy");
                            usuario.Rol.IdRol = ObjUsuario.Idrol;
                            usuario.UserName = ObjUsuario.UserName;
                            usuario.Password = ObjUsuario.Password;
                            usuario.CURP = ObjUsuario.CURP;
                            usuario.Direccion.Calle = ObjUsuario.NombreCalle;
                            usuario.Direccion.NumeroInterior = ObjUsuario.NumeroInterior;
                            usuario.Direccion.NumeroExterior = ObjUsuario.NumeroExterior;
                            usuario.Direccion.Colonia.IdColonia = ObjUsuario.IdColonia;
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = ObjUsuario.IdMunicipio;
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = ObjUsuario.IdEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = ObjUsuario.IdPais;

                            result.Object = usuario;

                        }

                        result.Correct = true;
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

        public static ML.Result AddEF(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();
            usuario.Direccion = new ML.Direccion();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Genero,
                        usuario.Correo, usuario.Telefono, usuario.FechaNacimiento, usuario.Rol.IdRol, usuario.UserName, usuario.Password, usuario.CURP
                        , null, true, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);



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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioUpdate(usuario.Id_Usuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Genero,
                        usuario.Correo, usuario.Telefono, usuario.FechaNacimiento,usuario.Rol.IdRol, usuario.UserName, usuario.Password, usuario.CURP, null,
                        true,usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);


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

        public static ML.Result DeleteEF(int Id_Usuario) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioDelete(Id_Usuario);

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

        public static ML.Result AddLINQ (ML.Usuario usuario) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {
                    DL_EF.Usuario usuarioLINQ = new DL_EF.Usuario();

                    usuarioLINQ.Id_Usuario = usuario.Id_Usuario;
                    usuarioLINQ.Nombre = usuario.Nombre;
                    usuarioLINQ.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioLINQ.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioLINQ.Genero = usuario.Genero;
                    usuarioLINQ.Correo = usuario.Correo;
                    usuarioLINQ.Telefono = usuario.Telefono;
                    usuarioLINQ.FechaDeNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioLINQ.Idrol = usuario.Rol.IdRol;
                    usuarioLINQ.UserName = usuario.UserName;
                    usuarioLINQ.Password = usuario.Password;
                    usuarioLINQ.CURP = usuario.CURP;

                    context.Usuarios.Add(usuarioLINQ);
                    context.SaveChanges();

                     result.Correct = true;
                    

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

        public static ML.Result UpdateLINQ(ML.Usuario usuario) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {                    

                    var query = (from user in context.Usuarios
                                 where user.Id_Usuario == usuario.Id_Usuario
                                 select user).SingleOrDefault();

                    if (query != null) {

                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Genero = usuario.Genero;
                        query.Correo = usuario.Correo;
                        query.Telefono = usuario.Telefono;
                        query.FechaDeNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                        query.Idrol = usuario.Rol.IdRol;
                        query.UserName = usuario.UserName;
                        query.Password = usuario.Password;
                        query.CURP = usuario.CURP;
                        
                        context.SaveChanges();
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

        public static ML.Result GetAllLINQ() {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var query = (from usuarios in context.Usuarios
                                 select usuarios).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var obj in query) {

                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Id_Usuario = obj.Id_Usuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Genero = obj.Genero;
                            usuario.Correo = obj.Correo;
                            usuario.Telefono = obj.Telefono;
                            usuario.FechaNacimiento = obj.FechaDeNacimiento.ToString();
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.Rol.IdRol;
                            usuario.UserName = obj.UserName;
                            usuario.Password = obj.Password;
                            usuario.CURP = obj.CURP;

                            result.Objects.Add(usuario);
                            context.SaveChanges();
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

        public static ML.Result GetByIdLINQ(int Id) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())

                {

                    var query = (from usuarios in context.Usuarios
                                 where usuarios.Id_Usuario == Id
                                 select usuarios).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var obj in query)
                        {

                            ML.Usuario usuarioLINQ = new ML.Usuario();

                        
                            usuarioLINQ.Nombre = obj.Nombre;
                            usuarioLINQ.ApellidoPaterno = obj.ApellidoPaterno;
                            usuarioLINQ.ApellidoMaterno = obj.ApellidoMaterno;
                            usuarioLINQ.Genero = obj.Genero;
                            usuarioLINQ.Correo = obj.Correo;
                            usuarioLINQ.Telefono = obj.Telefono;
                            usuarioLINQ.FechaNacimiento = obj.FechaDeNacimiento.ToString();
                            usuarioLINQ.Rol = new ML.Rol();
                            usuarioLINQ.Rol.IdRol = obj.Rol.IdRol;
                            usuarioLINQ.UserName = obj.UserName;
                            usuarioLINQ.Password = obj.Password;
                            usuarioLINQ.CURP = obj.CURP;

                            result.Objects.Add(usuarioLINQ);
                            context.SaveChanges();
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

        public static ML.Result DeleteLINQ(ML.Usuario usuario) {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.AMedinaProgramacionNCapasEntities1 context = new DL_EF.AMedinaProgramacionNCapasEntities1())
                    
                {

                    var query = (from usuarios in context.Usuarios
                                 where usuarios.Id_Usuario == usuario.Id_Usuario
                                 select usuarios).First();

                    context.Usuarios.Remove(query);
                    context.SaveChanges();

                        result.Correct = true;
                    

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
