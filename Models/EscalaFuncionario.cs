using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Imperio.Models
{
    public class EscalaFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Mes { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Data")]
        public DateTime Data { get; set; }
    }
}