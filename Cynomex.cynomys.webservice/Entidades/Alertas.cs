using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cynomex.cynomys.webservice.Entidades
{
    public class Alertas
    {
        int idAlerta;
        String lat;
        String lon;
        int idTipoAlerta;
        int idUsuario;
        bool status;
        DateTime registro;

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

        public string Lat
        {
            get
            {
                return lat;
            }

            set
            {
                lat = value;
            }
        }

        public string Lon
        {
            get
            {
                return lon;
            }

            set
            {
                lon = value;
            }
        }

        public int IdTipoAlerta
        {
            get
            {
                return idTipoAlerta;
            }

            set
            {
                idTipoAlerta = value;
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

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public DateTime Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
            }
        }
    }
}