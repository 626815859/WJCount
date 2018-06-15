
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bestwise.WJCourt.Persons
{
   public class Person:FullAuditedEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }
    }
}
