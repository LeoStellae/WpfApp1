using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.tables
{
    public class profile
    {
        [Key, ForeignKey("User")]
        public int Id { get; set; }
        public virtual user User { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string MiddleName { get; set; }

        
    }
}
