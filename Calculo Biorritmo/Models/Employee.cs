﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.Models
{
    public class employee
    {
        public int id { get; set; }
        public string curp { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime? fecha_accidente { get; set; }
        
    }
}
