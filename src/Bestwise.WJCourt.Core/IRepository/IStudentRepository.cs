using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bestwise.WJCourt.IRepository
{
   public interface IStudentRepository:IRepository<Students.Student>
    {
        List<Students.Student> GetStudentALL(string nameStart);
    }
}
