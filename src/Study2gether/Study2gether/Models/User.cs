using System;
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

        [Required(ErrorMessage = "Obrigatório Informar a Email!")]

        public string email { get; set; }

        public string description { get; set; }

        public string imageLink { get; set; }

        public string socialMedia { get; set; }

        public DateTime createdDate { get; set; }

        public bool isAdmin { get; set; }
    }

}