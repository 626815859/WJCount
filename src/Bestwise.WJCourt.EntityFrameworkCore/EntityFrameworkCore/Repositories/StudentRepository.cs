using Bestwise.WJCourt.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Bestwise.WJCourt.Students;
using Abp.EntityFrameworkCore;
using System.Linq;

namespace Bestwise.WJCourt.EntityFrameworkCore.Repositories
{
    public class StudentRepository : WJCourtRepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(IDbContextProvider<WJCourtDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取包含指定字母开头的学生列表
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentALL(string nameStart)
        {
            var query = GetAll();
            return query.Where(t => t.Name.StartsWith(nameStart)).ToList();
        }
    }
}
