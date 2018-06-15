using Abp.Domain.Services;
using Bestwise.WJCourt.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bestwise.WJCourt.Managers.StudentManager
{
    public interface IStudentManager : IDomainService
    {

        void SetStudentNameAddStr(Student student);
    }
}
