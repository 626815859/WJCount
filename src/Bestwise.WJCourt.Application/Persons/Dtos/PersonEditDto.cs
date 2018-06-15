using System.ComponentModel.DataAnnotations;
using Bestwise.WJCourt.Persons.Dtos.LTMAutoMapper;
using Bestwise.WJCourt.Persons;
using System.Collections.Generic;

namespace Bestwise.WJCourt.Persons.Dtos
{
    public class PersonEditDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }
    }
}