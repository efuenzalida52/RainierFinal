//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hw7
{
    using System;
    using System.Collections.Generic;
    
    public partial class VGSales_Table
    {
        public int GameID { get; set; }
        public Nullable<int> Rank { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public Nullable<int> Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public Nullable<decimal> NA_Sales { get; set; }
        public Nullable<decimal> EU_Sales { get; set; }
        public Nullable<decimal> JP_Sales { get; set; }
        public Nullable<decimal> Other_Sales { get; set; }
        public Nullable<decimal> Global_Sales { get; set; }
    }
}