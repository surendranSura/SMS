using SMS.Models.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.TimeTable
{
    public class PeriodDetail
    {
        public int PeriodDetailId { get; set; }

        [ForeignKey("StaffId")]
        public Staff Staffs { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("SubjectID")] 
        public Subject Subject { get; set; }

        public int Period { get; set; }

        public string Day { get; set; }
    }
}
