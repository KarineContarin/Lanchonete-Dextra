using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Models
{
    public class LancheModel
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public List<IngredienteModel> ingredientes;
    }
}