﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class configuracion
    {
        string voz;
        public static string  nombreAsistente;
        string nombreUsuario;

     

        public string NombreAsistente
        {
            get
            {
                return nombreAsistente;
            }

            set
            {
                nombreAsistente = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }
    }
}
