using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Study2gether.Models
{
    public class Post_Axis
    {
        public Guid idPost { get; set; }
        [ForeignKey("idPost")]
        public Post Post { get; set; }

        public Guid idAxis{ get; set; }
        [ForeignKey("idAxis")]
        public Axis Axis { get; set; }
    }

}