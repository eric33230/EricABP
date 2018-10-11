using System.ComponentModel.DataAnnotations;

namespace EricABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}