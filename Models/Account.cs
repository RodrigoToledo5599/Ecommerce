using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

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

        public Roles Role { get; set; }


        


    }
}
