using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Data
{
    internal class ApplicationDBContext
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(10000, 100000, ErrorMessage = "Salary lies between[10000,100000]")]
        public float Salary { get; set; }
    }
}
