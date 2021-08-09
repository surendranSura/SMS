using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.Inventory
{
    public class InventoryDefects
    {
        public int InventoryDefectsId { get; set; }

        [ForeignKey("ItemCode")]
        public String ItemCode { get; set; }

        [ForeignKey("ItemName")]
        public string ItemName { get; set; }

        public string DefectInfo { get; set; }


    }
}
