using Business.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models
{
    public class Lance: Entity
    {
        public double Valor { get; set; }


    }
}
