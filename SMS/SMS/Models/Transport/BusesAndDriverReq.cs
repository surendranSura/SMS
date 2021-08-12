using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.Transport
{
    public class BusesAndDriverReq
    {
        public int SeatCount { get; set; }

        public string BusNumber { get; set; }

        public string InsurancePolicyNum { get; set; }

        public DateTime InsuranceEndDate { get; set; }

        public string BusStatus { get; set; }

        public DateTime ArrivalTime { get; set; }

        public string DriverName { get; set; }

        public int DriverNumber { get; set; }

        public string DriverAadhar { get; set; }

        public byte BusLocation { get; set; }
    }
}
