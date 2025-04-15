using MultiApps.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Entities.Abstract
{
    public abstract class EntidadeBaseUsuarios
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public StatusEnum Status { get; set; }
        

    }
}
