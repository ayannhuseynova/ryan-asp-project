using System;
using System.ComponentModel.DataAnnotations;

namespace Ryan.WebUI.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We need your name! :(")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "We need your email! :(")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Don't forget to type in the message! :)")]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Response { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? ResponsedByUserId { get; set; }
    }
}
