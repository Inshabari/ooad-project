//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalLibrary.Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class BooksTable
    {
        public int ID { get; set; }
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public Nullable<int> CatagoryID { get; set; }
        public string PublishDate { get; set; }
        public Nullable<int> UploadedBy { get; set; }
        public string UploadingDate { get; set; }
        public string BookPath { get; set; }
        public string ImagePath { get; set; }
    }
}
