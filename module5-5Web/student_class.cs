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
    
    public partial class student_class
    {
        public int sc_id { get; set; }
        public int class_id { get; set; }
        public int student_id { get; set; }
    
        public virtual @class @class { get; set; }
        public virtual student student { get; set; }
    }
}
