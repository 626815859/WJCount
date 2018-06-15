using System;
using Abp.Application.Services.Dto;
using Bestwise.WJCourt.Persons.Dtos.LTMAutoMapper;
using Bestwise.WJCourt.Persons;
using System.Collections.Generic;

namespace Bestwise.WJCourt.Persons.Dtos
{
    public class PersonListDto : FullAuditedEntityDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}