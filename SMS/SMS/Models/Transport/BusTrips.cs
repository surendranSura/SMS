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


		[ForeignKey("BusesAndDriverId")]
		public BusesAndDriver BusesAndDrivers { get; set; }

		[ForeignKey("StudentId")]
		public Student Student { get; set; }


	}
}
