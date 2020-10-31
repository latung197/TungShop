using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TungShop.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }

    }
}
