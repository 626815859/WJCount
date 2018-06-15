using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bestwise.WJCourt.Persons;

namespace Bestwise.WJCourt.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
{
////BCC/ BEGIN CUSTOM CODE SECTION
////ECC/ END CUSTOM CODE SECTION
        [Required]
        public PersonEditDto Person { get; set; }

}
}