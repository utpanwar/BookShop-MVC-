using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
    public class CoverType      
    {
        public int Id { get; set; }
        //id is the primary key
        [Display(Name="Cover Type")]
        [Required]
        [MaxLength(50)]
        public int Name { get; set; }

    }
}
