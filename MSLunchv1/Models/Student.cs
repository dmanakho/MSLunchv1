using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSLunchv1.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("SIS ID"), MaxLength(50)]
        public string SISID { get; set; }
        [Required]
        [DisplayName("First Name"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name"), MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int Grade { get; set; }
        [DisplayName("Notes")]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DisplayFormat(NullDisplayText = "(not assigned)")]
        public int? TableID { get; set; }
        public virtual Table Table { get; set; }
    }
}
