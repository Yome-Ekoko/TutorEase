using TutorEase.Domain.Constant;
using TutorEase.Domain.Entities;

namespace TutorEase.Persistence.Seeds
{
    public static class DefaultRoles
    {
        public static List<T_Role> IdentityRoleList()
        {
            return new List<T_Role>()
            {
                new() {
                    Id = RoleConstants.Administrator,
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                    ConcurrencyStamp = "71f781f7-e957-469b-96df-9f2035147a23"
                },
                new() {
                    Id = RoleConstants.Log,
                    Name = Roles.Log,
                    NormalizedName = Roles.Log.ToUpper(),
                    ConcurrencyStamp = "71f781f7-e957-469b-96df-9f2035147a56"
                }
            };
        }
    }
}
