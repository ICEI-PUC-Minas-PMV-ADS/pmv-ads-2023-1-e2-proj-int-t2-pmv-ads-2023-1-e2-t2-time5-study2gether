using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Study2gether.Models
{
    public class Answer
    {
        [Key]
        public Guid idAnswer { get; set; }
        public Guid idPost { get; set; }
        [ForeignKey("idPost")]
        public Post Post { get; set; }

        public Guid idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }



        public string title { get; set; }

        [Required(ErrorMessage = "Obrigatório possuir conteúdo!")]
        public string content { get; set; }

        public DateTime created_date { get; set; }

        public virtual IList<Reaction> Reactions { get; } = new List<Reaction>();

    }
}
