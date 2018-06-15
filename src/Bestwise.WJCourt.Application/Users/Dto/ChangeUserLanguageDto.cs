using System.ComponentModel.DataAnnotations;

namespace Bestwise.WJCourt.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}