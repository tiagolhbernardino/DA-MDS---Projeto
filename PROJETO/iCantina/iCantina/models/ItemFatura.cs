﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class ItemFatura
    {
        public string Descricao { get; set; }
        public float Preco {  get; set; }

        // Class
        public Fatura Fatura { get; set; }
    }
}
