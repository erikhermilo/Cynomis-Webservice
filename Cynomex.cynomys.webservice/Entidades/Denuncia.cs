using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cynomex.cynomys.webservice.Entidades
{
    public class Denuncia
    {
        int idDenuncia;
        int idAlerta;
        String strMensaje;
        int idUsuario;

        public int IdDenuncia
        {
            get
            {
                return idDenuncia;
            }

            set
            {
                idDenuncia = value;
            }
        }

        public int IdAlerta
        {
            get
            {
                return idAlerta;
            }

            set
            {
                idAlerta = value;
            }
        }

        public string StrMensaje
        {
            get
            {
                return strMensaje;
            }

            set
            {
                strMensaje = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }
    }
}