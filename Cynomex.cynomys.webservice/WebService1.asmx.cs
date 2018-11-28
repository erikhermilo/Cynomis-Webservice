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
        public Entidades.Usuarios[] GetAllUsuarios()
        {
            try
            {
                List<Usuario> Listausuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();
                Entidades.Usuarios[] tempUS = new Entidades.Usuarios[Listausuarios.Count()];
                for (int i = 0; i < Listausuarios.Count(); i++)
                {
                    //asignamos el objeto persona uno por uno
                    Entidades.Usuarios temp = new Entidades.Usuarios();
                    temp.IdUsuario = Listausuarios[i].idUsuario;
                    temp.Usuario1 = Listausuarios[i].usuario1;
                    temp.Password = Listausuarios[i].password;
                    temp.Fecha_nacimiento = (DateTime) Listausuarios[i].fecha_nacimiento;
                    temp.Idsexo =(int) Listausuarios[i].idsexo;
                    temp.Nombre = Listausuarios[i].nombre;
                    temp.Email = Listausuarios[i].email;
                    temp.Status =(bool) Listausuarios[i].status;
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
        public Entidades.Usuarios GetUsuario(int id)
        {

            List<Usuario> Usuari = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();

            Usuario usuario = Usuari.FirstOrDefault((p) => p.idUsuario == id);
            if (usuario == null)
            {
                return null;
            }

            Cynomex.cynomys.webservice.Entidades.Usuarios user = new Entidades.Usuarios();

            user.IdUsuario = usuario.idUsuario;
            user.Nombre = usuario.nombre;
            user.Usuario1 = usuario.usuario1;
            user.Password = usuario.password;
            user.Fecha_nacimiento = (DateTime)usuario.fecha_nacimiento;
            user.Email = usuario.email;
            user.Idsexo = (int)usuario.idsexo;
            user.Status = (bool)usuario.status;

            return user;
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
                usu.email = email;
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
        public Entidades.Usuarios LoginUser(String Email, String Contrasenia)
        {
            try
            {
                Usuario usuario = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().Where(c => (c.email.Equals(Email.ToLower())) & (c.password.Equals(Contrasenia))).First();

                Cynomex.cynomys.webservice.Entidades.Usuarios user = new Entidades.Usuarios();

                user.IdUsuario = usuario.idUsuario;
                user.Nombre = usuario.nombre;
                user.Usuario1 = usuario.usuario1;
                user.Password = usuario.password;
                user.Fecha_nacimiento = (DateTime)usuario.fecha_nacimiento;
                user.Email = usuario.email;
                user.Idsexo =(int) usuario.idsexo;
                user.Status =(bool) usuario.status;

                return user;

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [WebMethod]
        public bool registrarMarca(string latitud, string longitud, int idtipoalerta, int idUsuario)
        {
            try
            {
                Alerta ale = new Alerta();
                ale.lat = latitud;
                ale.lon = longitud;
                ale.idTipoAlerta = idtipoalerta;
                ale.idUsuario = idUsuario;
                ale.status = true;
                ale.registro = System.DateTime.Now;

                dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Alerta>().InsertOnSubmit(ale);
                dcTemp.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        [WebMethod]
        public Entidades.Alertas[] GetAllMarcas()
        {
            try
            {
                List<Alerta> ListaAlertas = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Alerta>().ToList();
                Entidades.Alertas[] tempUS = new Entidades.Alertas[ListaAlertas.Count()];
                for (int i = 0; i < ListaAlertas.Count(); i++)
                {
                    if ((bool)ListaAlertas[i].status)
                    {
                        //asignamos el objeto persona uno por uno
                        Entidades.Alertas temp = new Entidades.Alertas();
                        temp.IdUsuario = (int)ListaAlertas[i].idUsuario;
                        temp.Lon = ListaAlertas[i].lon;
                        temp.Lat = ListaAlertas[i].lat;
                        temp.IdTipoAlerta = (int)ListaAlertas[i].idTipoAlerta;
                        temp.IdAlerta = (int)ListaAlertas[i].idAlerta;
                        temp.Registro = ListaAlertas[i].registro;
                        temp.Status = (bool)ListaAlertas[i].status;
                        tempUS[i] = temp;
                    }
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
        public bool StatusServicio()
        {
            try
            {
                return true;

            }
            catch (Exception _e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool registrarContacto(string nombre, string telefono, string email, int idUsuario)
        {
            try
            {
                    

                ContactoEmergencia Con = new ContactoEmergencia();
                Con.nombre = nombre;
                Con.telefono = telefono;
                Con.email = email;
                Con.idUsuario = idUsuario;
                Con.prioridad = 0;

                dcTemp.GetTable<Cynomex.cynomys.webservice.Models.ContactoEmergencia>().InsertOnSubmit(Con);
                dcTemp.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        [WebMethod]
        public Entidades.ContactoEmergencia GetContacto(int idUsuario)
        {

            List<ContactoEmergencia> Contacto = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.ContactoEmergencia>().ToList();

            ContactoEmergencia Cont1 = Contacto.FirstOrDefault((p) => p.idUsuario == idUsuario);
            if (Cont1 == null)
            {
                return null;
            }

            Cynomex.cynomys.webservice.Entidades.ContactoEmergencia user = new Entidades.ContactoEmergencia();

            user.IdUsuario = (int) Cont1.idUsuario;
            user.Nombre = Cont1.nombre;
            user.IdContactoEmergencia = Cont1.idContactoEmergencia;
            user.Email = Cont1.email;
            user.Prioridad = (int) Cont1.prioridad;
            user.Telefono = Cont1.telefono;

            return user;
        }


        [WebMethod]
        public bool UpdateContacto(string nombre, string telefono, string email, int idContactoemergencia)
        {

            ContactoEmergencia Contacto = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.ContactoEmergencia>().Where(c => c.idContactoEmergencia == idContactoemergencia).FirstOrDefault();
            
            if (Contacto == null)
            {
                return false;
            }
            

            Contacto.nombre = nombre;
            Contacto.email = email;
            Contacto.telefono = telefono;

            dcTemp.SubmitChanges();
            dcTemp.Dispose();
            return true;
        }

        [WebMethod]
        public bool setDenuncia(int idAlerta, string strMensaje, int idUsuario)
        {
            try
            {
                Denuncia de = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Denuncia>().Where(c => (c.idUsuario == idUsuario) && (c.idAlerta == idAlerta)).FirstOrDefault();

                if (de != null) {
                    return false;
                }
                Denuncia Den = new Denuncia();
                Den.idAlerta = idAlerta;
                Den.strMensaje = strMensaje;
                Den.idUsuario = idUsuario;

                dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Denuncia>().InsertOnSubmit(Den);
                dcTemp.SubmitChanges();
                dcTemp.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
