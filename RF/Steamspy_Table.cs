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
    
    public partial class Steamspy_Table
    {
        public Nullable<int> GameID { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Average_Score_Rank { get; set; }
        public Nullable<double> User_Score { get; set; }
        public Nullable<double> Metacritic_Score { get; set; }
        public Nullable<int> Estimated_Owners { get; set; }
        public string Average_Playtime { get; set; }
        public string Developer_s_ { get; set; }
        public string Publisher_s_ { get; set; }
    
        public virtual VGSales_Table VGSales_Table { get; set; }
    }
}
