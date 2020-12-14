using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.tables
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }

        public string Comment { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual user User { get; set; }

    }

}
