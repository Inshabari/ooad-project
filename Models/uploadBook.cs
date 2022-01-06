using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalLibrary.Models
{
    public class uploadBook
    {
        public long BookID { get; set; }

        [Required]
        [MaxLength(40)]
        public string bookName { get; set; }


        [Required]
        [MaxLength(40)]
        public string writerName { get; set; }
        public string bookCatagory { get; set; }

        [Required]
        public string publishDate { get; set; }

        public int uploadedBy { get; set; }

        public string uploadingDate { get; set; }

        
        public string bookPath { get; set; }

        public string imagePath { get; set; }

        [MaxLength(100)]
        public string searchTag { get; set; }


        [Required]
        public HttpPostedFileBase ImageFile { get; set; }


        [Required]
        public HttpPostedFileBase pdfFile { get; set; }
    }
}