//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class bangku
    {
        public string seat_no { get; set; }
        public string no_pesawat { get; set; }
    
        public virtual penerbangan penerbangan { get; set; }
    }
}
