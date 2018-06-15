using Abp.Domain.Services;
using Bestwise.WJCourt.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bestwise.WJCourt.Managers.StudentManager
{
    public class StudentManager : DomainService, IStudentManager
    {

        public const string AddNameStr = "_WJCourt";
        private readonly IStudentRepository _studentRepository;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="studentRepository"></param>
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        /// <summary>
        /// 修改指定实体name+str
        /// </summary>
        /// <param name="student">实体</param>
        public void SetStudentNameAddStr(Students.Student student)
        {
            student.Name = student.Name + AddNameStr;
            _studentRepository.Update(student);
        }
    }
}
