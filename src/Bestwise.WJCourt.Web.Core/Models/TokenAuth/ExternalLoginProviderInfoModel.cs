using Abp.AutoMapper;
using Bestwise.WJCourt.Authentication.External;

namespace Bestwise.WJCourt.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
