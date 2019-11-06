using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitchAssCodeFirst
{
    [Table("StudentMaster")]
    public class Student
    {
        [Key]
        [Column(Order = 1)]
        public int StudentID { get; set; }
        [Column(Order = 2)]
        public string StudentName { get; set; }
        [Column("DoB", TypeName = "DateTime2")]
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }

    }
}
