using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bestwise.WJCourt.Student.Dtos
{

        [AutoMapFrom(typeof(Students.Student))]  //Dto自动映射
        public class StudentOuput : EntityDto
    {

            public string Name { get; set; }


            public string Sex { get; set; }
        }
}
