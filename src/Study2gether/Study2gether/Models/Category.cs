using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Category
    {
        [Key]
        public Guid idCategory { get; set; }

        // [Required(ErrorMessage = "Obrigatório fornecer uma categoria!")]
        public string name{ get; set; }
    }

}