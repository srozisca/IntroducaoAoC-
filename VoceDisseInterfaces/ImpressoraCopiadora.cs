﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    public class ImpressoraCopiadora : IImpressora, ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto a ser copiado: {texto}";
        }

        public string Imprimir(string texto)
        {
            return $"Texto a imprimir: {texto}";
        }
    }
}
