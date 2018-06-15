using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bestwise.WJCourt.Persons.Dtos
{
  public  class PersonInput:EntityDto
    {
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
