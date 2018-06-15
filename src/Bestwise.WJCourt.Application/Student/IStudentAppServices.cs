using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bestwise.WJCourt.Student.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bestwise.WJCourt.Student
{
    
   public interface IStudentAppServices:IApplicationService
    {
        int CreateStudent(CreateStudentInput input);
        Task<StudentOuput> GetStudentByIdAsync(int id);
        StudentOuput GetStudentByName(string name);
        void SetStudentNameAddStr(string name);
    }
}
