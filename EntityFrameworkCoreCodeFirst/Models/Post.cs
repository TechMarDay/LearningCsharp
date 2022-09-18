using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreCodeFirst.Models
{
    [Table("Post")]
    
    public class Post
    {
        [Key ]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        [Required]
        public int UserId { get; set; }
        [Required]   
        
        public int CategoryId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        
        public DateTime? CreateDate { get; set; }       
        public DateTime? UpdateDate { get; set; }       
        public int? UpdateUserId { get; set; }    
        public Category? Category { get; set; }
    }
}
