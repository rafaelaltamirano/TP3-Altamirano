﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Voucher
    {
        public int Id { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int FechaRegistro { get; set; }
    }
}
