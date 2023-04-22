using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

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

        public ICollection<Post_Axis> Post_Axis { get; set; }
        public ICollection<Post_Microfoundation> Post_Microfoundation { get; set; }
        public ICollection<Post_Category> Post_Category { get; set; }
    }

}