using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFipe.Domain.Model
{
    public class Fipe
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }    
        public decimal Preco { get; set; }  
        public string Codigo { get; set; }
        public decimal PrecoMedia { get; set; }
    }
}
