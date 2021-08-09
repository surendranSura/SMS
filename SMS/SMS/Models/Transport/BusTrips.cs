using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.Transport
{
    public class BusTrips
    {
        public int BusTripsid { get; set; }

        public int TripNumber { get; set; }

        public string TripAreas { get; set; }

        public TimeSpan TripTimingFrom { get; set; }

        public TimeSpan TripTimingTo { get; set; }

        public int TotalHeadCount { get; set; }

        [ForeignKey("BusNumber")]
        public int BusNmber { get; set; }

        [ForeignKey("DriverNumber")]
        public int DriverNumber { get; set; }

        [ForeignKey("DriverName")]
        public string DriverName { get; set; }

        [ForeignKey("Class")]
        public string StudentClass { get; set; }

        [ForeignKey("Section")]
        public string StudentSection { get; set; }

        public string StudentList { get; set; }


    }
}
