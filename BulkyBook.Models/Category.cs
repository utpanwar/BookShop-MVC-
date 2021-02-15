using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        //id is the primary key
        [Display(Name="Category name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
