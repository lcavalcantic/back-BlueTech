using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda.Data;

namespace agenda.Model
{
    public class Agenda
    {
        public int Id { get; set; }
        public string? Nome { get; set;}
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}