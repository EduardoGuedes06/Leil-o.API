using Business.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models
{
    public class Lance : Entity
    {
        public Guid UsuarioId {get; set;}
        public Guid LeilaoId { get; set;}
        public Usuario Usuario { get; set; }
        public Leilao Leilao { get; set; }
        public double Valor { get; set; }


    }
}
