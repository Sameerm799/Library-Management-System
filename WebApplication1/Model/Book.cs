using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Book
    {
        [Key]

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Author { get; set; }

        public string ISBN { get; set; }
    }
}
