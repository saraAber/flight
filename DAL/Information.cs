//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Information
    {
        public int Id { get; set; }
        public int IdFlight { get; set; }
        public int IdType { get; set; }
        public string WhoPay { get; set; }
        public int countryId { get; set; }
        public int Length { get; set; }
        public double Cost { get; set; }
        public System.DateTime Date { get; set; }
        public int Coin { get; set; }
        public int Pya { get; set; }
    
        public virtual Coin Coin1 { get; set; }
        public virtual Country Country { get; set; }
        public virtual FlightInfor FlightInfor { get; set; }
        public virtual TypeInfo TypeInfo { get; set; }
    }
}