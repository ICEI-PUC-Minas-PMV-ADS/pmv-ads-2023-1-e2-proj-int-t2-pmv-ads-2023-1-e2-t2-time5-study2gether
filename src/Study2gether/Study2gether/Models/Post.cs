using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Post
    {
        [Key]
        public Guid idPost { get; set; }

        [Required(ErrorMessage = "Obrigatório escolher um tipo!")]
        public string type { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer um título!")]
        public string title { get; set; }

        [Required(ErrorMessage = "Obrigatório possuir conteúdo!")]
        public string content { get; set; }

        public int views{ get; set; }

        public DateTime created_date { get; set; }

        public Guid idUser{ get; set; }

        [ForeignKey("idUser")]
        public User User { get; set; }  
    }

}