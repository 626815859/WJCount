using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bestwise.WJCourt.Students
{
    public class Student : FullAuditedEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }
    }
}
