//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssignmentFIT5032.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HotelLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HotelId { get; set; }
        [DisplayFormat(DataFormatString = "{0:###.########}")]
        public decimal Latitude { get; set; }
        [DisplayFormat(DataFormatString = "{0:###.########}")]
        public decimal Longitude { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}