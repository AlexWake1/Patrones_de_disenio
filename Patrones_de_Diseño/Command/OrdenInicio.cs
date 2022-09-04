﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseño.Command
{
    class OrdenInicio : IOrdenEnAula1
    {
        Aula aula;
        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void Ejecutar()
        {
            aula.Comenzar();
        }
    }
}
