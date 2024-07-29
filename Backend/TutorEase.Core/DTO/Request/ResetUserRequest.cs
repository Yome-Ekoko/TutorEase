using System.ComponentModel.DataAnnotations;

namespace TutorEase.Core.DTO.Request
{
    public class ResetUserRequest
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
    }
}
