using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DenTemplate.Models
{
    public class About
    {
        [Key]
        public int Id{ get; set; }
        [NotMapped]
        public IFormFile Image{ get; set; }
        [MaxLength (150)]
        public string ImageFile { get; set; }
        [MaxLength(50)]
        public string ProductName{ get; set; }
        [MaxLength(300)]
        public string Context { get; set; }
    }
}
