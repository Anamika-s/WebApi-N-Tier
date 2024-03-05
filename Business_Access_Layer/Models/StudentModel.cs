using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Access_Layer.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Range(0, 100, ErrorMessage = "Range is 0 to 100")]
        public int Marks { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
