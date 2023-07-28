using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        
        [StringLength(63)]
        public string Pais { get; set; }
                
        [StringLength(15)]
        public string CEP { get; set; }

        [StringLength(63)]
        public string Endereco { get; set; }

        [StringLength(63)]
        public string Complemento { get; set; }

        [StringLength(63)]
        public string Estado { get; set; }



    }
}
 