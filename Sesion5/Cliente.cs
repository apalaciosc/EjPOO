using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sesion5
{
    public class Cliente
    {
        private string id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string celular;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
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

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }
    }
}
