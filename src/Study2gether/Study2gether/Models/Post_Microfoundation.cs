using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Post_Microfoundation
    {
        public Guid idPost { get; set; }
        [ForeignKey("idPost")]
        public Post Post { get; set; }

        public Guid idMicrofoundation { get; set; }
        [ForeignKey("idMicrofoundation")]
        public Microfoundation Microfoundation { get; set; }
    }
}