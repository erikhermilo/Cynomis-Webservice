using Cynomex.cynomys.webservice.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cynomex.cynomys.webservice.Controllers
{
    public class UsuarioController : ApiController
    {
        DataContext dcTemp = new DataClasses1DataContext();
        
        public IEnumerable<Usuario> GetAllUsuarios()
        {
            List<Usuario> Usuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();

            return Usuarios;
        }
        public IHttpActionResult GetUsuario(int id)
        {

            List<Usuario> Usuarios = dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().ToList();

            var Usuario = Usuarios.FirstOrDefault((p) => p.idUsuario == id);
            if (Usuario == null)
            {
                return NotFound();
            }
            return Ok(Usuario);
        }

        public IHttpActionResult setUsuario(int id, string nickname, string password, DateTime fechaN, int sexo, string nombre, string email)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.idUsuario = id;
                usu.usuario1 = nickname;
                usu.password = password;
                usu.fecha_nacimiento = fechaN;
                usu.idsexo = sexo;
                usu.nombre = nombre;
                usu.email = email;
                usu.status = true;

                dcTemp.GetTable<Cynomex.cynomys.webservice.Models.Usuario>().InsertOnSubmit(usu);
                dcTemp.SubmitChanges();

                return Ok(true);
            }
            catch (Exception e)
            {
                return Ok(false);
            }
        }
    }
}
