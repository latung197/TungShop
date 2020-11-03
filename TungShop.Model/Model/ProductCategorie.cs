using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TungShop.Model.Abstract;

namespace TungShop.Model.Model
{
    [Table("ProductCategprys")]
    public class ProductCategorie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(500)][Required]
        public string Name { get; set; }
        [MaxLength(50)][Required]
        public string Alias { get; set; }

        public int ParentID { get; set; }
        [MaxLength(50)]
        public bool HomeFlag { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Warranty { get; set; }



        public virtual IEnumerable<Product> Products { get; set; }

    }
}
