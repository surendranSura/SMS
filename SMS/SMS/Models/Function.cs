using System;
using System.Collections.Generic;

#nullable disable

namespace SMS.Models
{
    public partial class Function
    {
        public int FunctionId { get; set; }
        public string Decription { get; set; }
        public string DisplayValue { get; set; }
        public string DisplayOrder { get; set; }
        public int? ParentFunctionId { get; set; }
    }
}
