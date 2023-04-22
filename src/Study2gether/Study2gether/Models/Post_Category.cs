using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Post_Category
    {
        public Guid idPost{ get; set; }
        [ForeignKey("idPost")]
        public Post Post { get; set; }

        public Guid idCategory { get; set; }
        [ForeignKey("idCategory")]
        public Category Category { get; set; } 
    }

}