using System.ComponentModel.DataAnnotations;

namespace TutorEase.Core.DTO.Request
{
    public class DeleteUserRequest
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
    }
}
