using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TungShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }
        [Required]
        public string Conten { set; get; }

    }
}
