using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteCep2.Models
{
    public class Cep
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(8)]
        public string NumCep { get; set; }

        [MaxLength(500)]
        public string Logradouro { get; set; }

        [MaxLength(500)]
        public string Complemento { get; set; }

        [MaxLength(500)]
        public string Bairro { get; set; }

        [MaxLength(500)]
        public string Localidade { get; set; }

        [MaxLength(2)]
        public string Uf { get; set; }

        [Column(TypeName = "bigint")]
        public Int64? Unidade { get; set; }

        public int? Ibge { get; set; }

        [MaxLength(500)]
        public string Gia { get; set; }

    }
}