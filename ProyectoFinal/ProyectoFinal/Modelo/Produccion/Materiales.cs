﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelo.Produccion
{
    class Materiales
    {
        public int IdMaterial { get; set; }
        public String Descripcion { get; set; }
        public double Costo { get; set; }
        public int Existencia { get; set; }
        public TiposMateriales Tipo { get; set; }

        public enum TiposMateriales : int
        {

            Insumos = 1,
            Base = 2,
            Combustible = 3
        }
    }
}
