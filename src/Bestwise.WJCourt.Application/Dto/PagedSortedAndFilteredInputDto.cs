using Bestwise.WJCourt.Persons;

namespace Bestwise.WJCourt.Dto
{
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public string Filter { get; set; }
    }
}