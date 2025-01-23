using System.ComponentModel.DataAnnotations;

namespace Sample1.DTOs
{
    public class DesignationCreateDTO
    {
        [Required(ErrorMessage = "The Name field is required.")]
        [MinLength(3)]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Special characters and Digits are not allowed.")]
        public string Name { get; set; }
    }
}
