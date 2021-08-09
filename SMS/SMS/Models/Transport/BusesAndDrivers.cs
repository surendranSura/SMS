using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.Transport
{
    public class BusesAndDrivers
    {
        public int BusesAndDriversid { get; set; }

        public string BusType { get; set; }

        public int SeatCount { get; set; }

        public int BusNumber { get; set; }

        public int InsurancePolicyNum { get; set; }

        public DateTime InsuranceEndDate { get; set; }

        public string NotificationSpan { get; set; }

        public string BusStatus { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public string DriverName { get; set; }

        public int DriverNumber { get; set; }

        public int DriverAadhar { get; set; }

        public byte BusLocation { get; set; }
    }
}
