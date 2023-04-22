using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Study2gether.Models
{
    public class Microfoundation
    {
        [Key]
        public Guid idMicrofoundation { get; set; }

        // [Required(ErrorMessage = "Obrigatório fornecer uma categoria!")]
        public string name{ get; set; }

        public ICollection<Post_Microfoundation> Post_Microfoundation { get; set; }
    }
}