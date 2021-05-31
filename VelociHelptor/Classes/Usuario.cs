using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace VelociHelptor
{
    class Usuario
    {

        private Tipo Tipo { get; set; } //Opção por tipo de usuário
        private string Nome { get; set; }
        private string Email { get; set; }


        public Usuario (Tipo Tipo, string Nome, string Email)
        {
            this.Tipo = Tipo;
            this.Nome = Nome;
            this.Email = Email;

        }
       


    }
}
