using System.ComponentModel.DataAnnotations.Schema;

namespace EvotesWebApplication.Data
{
    public class Parishes : BaseEntity
    {       
        [ForeignKey("CandidatesId")]
        public Candidates candidates { get; set; }
        public int CandidatesId { get; set; }
        public string ParishName { get; set; }
        public string ParishesCandidateName { get; set; }
        public DateTime EnteredDate { get; set; }
    }
}
