using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Study2gether.Models
{
    public class Category
    {
        [Key]
        public Guid idCategory { get; set; }

        // [Required(ErrorMessage = "Obrigatório fornecer uma categoria!")]
        public string name{ get; set; }

        public virtual IList<Post> Posts { get; } = new List<Post>();
    }

}