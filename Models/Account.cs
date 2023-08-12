using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [StringLength(63)]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(127)]
        public string Email { get; set; }

        [Required]
        [StringLength(127)]
        public string Senha { get; set; }

        






        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }

    }
}
