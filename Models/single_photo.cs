//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class single_photo
    {
        public int id { get; set; }
        public byte[] anno { get; set; }
        public byte[] img { get; set; }
        public string annoaddress { get; set; }
        public string imgaddress { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Nullable<int> totalobject { get; set; }
        public string name { get; set; }
    }
}
