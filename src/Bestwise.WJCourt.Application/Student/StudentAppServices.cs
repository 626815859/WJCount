using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bestwise.WJCourt.Student.Dtos;
using Abp.Domain.Repositories;
using AutoMapper;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Linq;
using Bestwise.WJCourt.IRepository;
using Bestwise.WJCourt.Managers.StudentManager;
using Bestwise.WJCourt.Students;

namespace Bestwise.WJCourt.Student
{
   public class StudentAppServices : WJCourtAppServiceBase, IStudentAppServices
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        private readonly IRepository<Students.Student> _iRepository;

        private readonly IStudentRepository _iStudentRepository;   //自定义仓储


        private readonly IStudentManager _studentManager;        //领域服务


        /// <summary>
        /// 构造函数注入
        /// </summary>
        public StudentAppServices(IRepository<Students.Student> studentRepository, IStudentRepository iStudentRepository, IStudentManager studentManager)
        {
            _iRepository = studentRepository;
            _iStudentRepository = iStudentRepository;
            _studentManager = studentManager;
        }

        /// <summary>
        /// 获取包含指定字母开头的学生列表
        /// </summary>
        /// <returns></returns>
        public List<StudentOuput> GetStudentALL(string nameStart)
        {
            return Mapper.Map<List<StudentOuput>>(_iStudentRepository.GetStudentALL(nameStart));

        }
        /// <summary>
        /// 创建学生
        /// </summary>
        /// <param name="input">id</param>
        /// <returns></returns>
        public int CreateStudent(CreateStudentInput input)
        {
            try
            {
                Students.Student student = Mapper.Map<CreateStudentInput, Students.Student>(input);
                return  _iRepository.InsertAndGetId(student);

            }
            catch (System.Exception)
            {
                return 0;

            }
        }

        /// <summary>
        /// 获取指定name的实体
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public StudentOuput GetStudentByName(string name)
        {
            return Mapper.Map<StudentOuput>(_iRepository.GetAll().Where(u=>u.Name==name).SingleOrDefault());
        }

        /// <summary>
        /// 获取指定id的学生
        /// </summary>
        /// <param name="input">id</param>
        /// <returns></returns>
        public async Task<StudentOuput> GetStudentByIdAsync(int id)
        {
            var entity = await _iRepository.GetAsync(id);

            return entity.MapTo<StudentOuput>();
        }

        /// <summary>
        /// 修改指定实体name+str
        /// </summary>
        /// <param name="student">实体</param>
        public void SetStudentNameAddStr(string name)
        {
            var stu = _iRepository.Single(u => u.Name == name);
           _studentManager.SetStudentNameAddStr(stu);
        }
    }
}
