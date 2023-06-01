using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Study2gether.Models
{
    public class ForgotPassword
    {
        [Key]
        public Guid idForgotPass { get; set; }

        [Required, EmailAddress, Display(Name = "Email registrado")]
        public string email { get; set; }
        public bool emailSent { get; set; }
        public Guid passwordResetToken { get; set; }//Not really secure as token, but will do for this app.

        public DateTime created_date { get; set; }
    }
}
