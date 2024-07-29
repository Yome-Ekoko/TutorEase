using TutorEase.Domain.Constant;
using TutorEase.Domain.Entities;

namespace TutorEase.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<T_UserRole> IdentityUserRoleList()
        {
            return new List<T_UserRole>()
            {
                new T_UserRole
                {
                    RoleId = RoleConstants.Log,
                    UserId = RoleConstants.LogUser
                },
                new T_UserRole
                {
                    RoleId = RoleConstants.Administrator,
                    UserId = RoleConstants.AdministratorUser
                }
            };
        }
    }
}
