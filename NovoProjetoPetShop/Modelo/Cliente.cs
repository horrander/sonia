using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjetoPetShop.Modelo
{
    public class Cliente
    {

        public int IdentificadorDaPessoa { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String DataDeNascimento { get; set; }
        public String NomeDoPet { get; set; }
        public String DataDeAlteracao { get; set; }   
        public String DataDeExclusao { get; set; }

    }
}
