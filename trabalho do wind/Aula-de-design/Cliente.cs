using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_de_design
{
    public class Cliente
    {
        public int IdCliente { get; set }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }


        public override string ToString()
        {
            return $"IdCliente:{IdCliente}, Name:{Name}, Telefone:{Telefone}, Endereço:{Endereço}, Cidade:{Cidade} ";
        }
    }
