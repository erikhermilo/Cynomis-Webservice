using Cynomex.cynomys.webservice.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace Cynomex.cynomys.webservice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        DataContext dcTemp = new DataClasses1DataContext();

        [WebMethod]
        public Usuario[] GetAllUsuarios()
        {
            try
            {
                List<Usuario> Listausuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();
                Usuario[] tempUS = new Usuario[Listausuarios.Count()];
                for (int i = 0; i < Listausuarios.Count(); i++)
                {
                    //asignamos el objeto persona uno por uno
                    Usuario temp = new Usuario();
                    temp.idUsuario = Listausuarios[i].idUsuario;
                    temp.usuario1 = Listausuarios[i].usuario1;
                    temp.password = Listausuarios[i].password;
                    temp.fecha_nacimiento = Listausuarios[i].fecha_nacimiento;
                    temp.Sexo = Listausuarios[i].Sexo;
                    temp.nombre = Listausuarios[i].nombre;
                    temp.email = Listausuarios[i].email;
                    temp.status = Listausuarios[i].status;
                    //asignamos el objeto catsexo adjunto al de persona
                    Sexo catSexoTemp = new Sexo();
                    catSexoTemp.idSexo = Listausuarios[i].Sexo.idSexo;
                    catSexoTemp.Nombre  = Listausuarios[i].Sexo.Nombre;
                    temp.Sexo = catSexoTemp;
                    tempUS[i] = temp;
                }
                dcTemp.Dispose();

                return tempUS;

            }
            catch (Exception _e)
            {
                return null;
            }

        }


        [WebMethod]
        public Usuario GetUsuario(int id)
        {

            List<Usuario> Usuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();

            Usuario Usuario = Usuarios.FirstOrDefault((p) => p.idUsuario == id);
            if (Usuario == null)
            {
                return null;
            }
            return Usuario;
        }

        [WebMethod]
        public bool setUsuario( string nickname, string password, DateTime fechaN, int sexo, string nombre, string email)
        {
            try
            {
                Usuario usu = new Usuario();
                usu.usuario1 = nickname;
                usu.password = password;
                usu.fecha_nacimiento = fechaN;
                usu.idsexo = sexo;
                usu.nombre = nombre;
                usu.email = email.ToLower();
                usu.status = true;

                dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().InsertOnSubmit(usu);
                dcTemp.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        [WebMethod]
        public Usuario LoginUser(String Email, String Contraseña)
        {
            try
            {
                Usuario Usuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().Where(c => (c.email.Equals(Email.ToLower())) & (c.password.Equals(Contraseña))).First();


                return Usuarios;

            }catch
            {
                return null;
            }

        }
    }
}
