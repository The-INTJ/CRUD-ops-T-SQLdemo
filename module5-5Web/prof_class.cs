//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace module5_5Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class prof_class
    {
        public int pc_id { get; set; }
        public int prof_id { get; set; }
        public int class_id { get; set; }
    
        public virtual @class @class { get; set; }
        public virtual professor professor { get; set; }
    }
}
