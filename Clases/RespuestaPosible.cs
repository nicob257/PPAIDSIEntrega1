﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    public class RespuestaPosible
    {
        private int Id;
        private string Descripcion;
        private string Valor;

        public RespuestaPosible(string descripcion, string valor, int id)
        {
            Descripcion = descripcion;
            Valor = valor;
            Id = id;
        }

        public string obtenerDatos()
        {
            return this.Descripcion;
        }

        public int obtenerId()
        {
            return this.Id;
        }
    }
}


