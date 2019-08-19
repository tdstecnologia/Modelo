using AspNetCoreMvcCrudPostgreSQL.Dominio;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvcCrudPostgreSQL.Models
{
    [Table("tb01_curso")]
    public class Curso
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("quantidade_aula")]
        public int QuantidadeAula { get; set; }

        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [Column("turno")]
        public DomTurno Turno { get; set; }
    }
}
