using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Reaction
    {
        [Key]
        public Guid Id { get; set; }
        //necessario criar uma nova tabela de FG simples para nomes de reações
        [Required]
        public string Name { get; set; }
        
        [Required]
        public Guid idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        public Guid? idAnswer { get; set; }
        [ForeignKey("idAnswer")]
        public Answer Answer { get; set; }

        public Guid? idPost { get; set; }
        [ForeignKey("idPost")]
        public Post Post { get; set; }

    }
}