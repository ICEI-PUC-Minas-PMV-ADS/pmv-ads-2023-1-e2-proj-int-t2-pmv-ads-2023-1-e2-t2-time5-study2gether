using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class User
    {
        [Key]

        public Guid idUser { get; set; }

        public string name { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]

        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]

        public string email { get; set; }

        public string description { get; set; }

        public string imageLink { get; set; }

        public string socialMedia { get; set; }

        public DateTime createdDate { get; set; }

        public bool isAdmin { get; set; }

        public virtual IList<Post> Posts { get; } = new List<Post>();
        public virtual IList<Answer> Answers { get; } = new List<Answer>();
        public virtual IList<Reaction> Reactions { get; } = new List<Reaction>();

    }

}