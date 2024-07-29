using TutorEase.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace TutorEase.Domain.QueryParameters
{
    public class UserQueryParameters : UrlQueryParameters
    {
        [DataType(DataType.Text)]
        public string? Query { get; set; }
        [DataType(DataType.Text)]
        public string? Role { get; set; }
        [DataType(DataType.Text)]
        public UserStatus? Status { get; set; }
    }
}
