using Abp.MultiTenancy;
using Bestwise.WJCourt.Authorization.Users;

namespace Bestwise.WJCourt.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
