//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATN
{
    using System;
    using System.Collections.Generic;
    
    public partial class RFID_User
    {
        public int ID { get; set; }
        public string RFID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual RFIDManage RFIDManage { get; set; }
        public virtual User User { get; set; }
    }
}
