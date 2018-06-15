using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Bestwise.WJCourt.Persons;

namespace Bestwise.WJCourt.Persons.DomainServices
{
    public interface IPersonManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitPerson();

    }
}
