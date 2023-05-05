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
        public Types type { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer um título!")]
        public string title { get; set; }

        [Required(ErrorMessage = "Obrigatório possuir conteúdo!")]
        public string content { get; set; }

        public int views{ get; set; }

        public DateTime created_date { get; set; }

        public Guid idUser{ get; set; }

        [ForeignKey("idUser")]
        public User User { get; set; }

        public virtual IList<Microfoundation> Microfoundations { get; } = new List<Microfoundation>();
        public virtual IList<Category> Categories { get; } = new List<Category>();
        public virtual IList<Axis> Axes { get; } = new List<Axis>();
        public virtual IList<Answer> Answers { get; } = new List<Answer>();
        public virtual IList<Reaction> Reactions { get; } = new List<Reaction>();
    }
    public enum Types
    {
        Indication,
        Interaction,
        Question,
    }

}