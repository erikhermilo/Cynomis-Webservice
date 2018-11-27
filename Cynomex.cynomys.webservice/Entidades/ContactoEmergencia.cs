using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cynomex.cynomys.webservice.Entidades
{
    public class ContactoEmergencia
    {
        private int idContactoEmergencia;

        private string nombre;

        private string telefono;

        private string email;

        private int idUsuario;

        private int prioridad;

        public int IdContactoEmergencia
        {
            get
            {
                return idContactoEmergencia;
            }

            set
            {
                idContactoEmergencia = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public int Prioridad
        {
            get
            {
                return prioridad;
            }

            set
            {
                prioridad = value;
            }
        }
    }
}