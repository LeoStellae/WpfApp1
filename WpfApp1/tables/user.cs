using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.tables
{
    [Table("Users")] 
    public class user
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        [StringLength(25)]
        public string login { get; set; }
        [Required]
        [StringLength(25)]
        public string password { get; set; }

        public virtual profile Profile { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
