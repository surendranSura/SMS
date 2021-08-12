using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.Inventory
{
    public class InventoryReq
    {
        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public int ModelNumber { get; set; }

        public string SerialNumber { get; set; }

        public string Brand { get; set; }

        public int Quantity { get; set; }

        public string WarrenOrGarantee { get; set; }

        public string WarrenOrGarenInfo { get; set; }

        public int Price { get; set; }

        public int VendorNumber { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress { get; set; }

        public byte BillCopy { get; set; }
    }
}
