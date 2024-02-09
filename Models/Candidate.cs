using System.ComponentModel.DataAnnotations;

namespace TheRegista.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public String? Email { get; set; } = String.Empty;
        
        [Required(ErrorMessage = "FirstName is required.")]
        public String? FirstName { get; set; } = String.Empty;
        
        [Required(ErrorMessage = "LastName is required.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public string? Size { get; set; }
        public String? SelectedItem { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}