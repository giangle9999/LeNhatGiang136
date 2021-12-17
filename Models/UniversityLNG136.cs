using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace LeNhatGiang136.Models
{
    public class UniversityLNG136
    {
        [Key]
        [StringLength(20)]
        public string UniversityId { get; set; }
        [StringLength(50)]
        public string UniversityName { get; set; }
    }
}