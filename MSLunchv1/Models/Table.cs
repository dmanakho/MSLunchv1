using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSLunchv1.Models
{
    public class Table
    {
        public Table()
        {
            Students = new HashSet<Student>();
        }
        public int ID { get; set; }
        public int TableNo { get; set; }
        public int TableGrade { get; set; }
        public int TableCapacity { get; set; }
        public string TableDescription { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
