using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cynomex.cynomys.webservice.Entidades
{
    public class Usuarios
    {
        int idUsuario;
        String usuario;
        String password;
        DateTime fecha_nacimiento;
        int idsexo;
        String nombre;
        String email;
        bool status;

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

        public string Usuario1
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

        public int Idsexo
        {
            get
            {
                return idsexo;
            }

            set
            {
                idsexo = value;
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
    }
}