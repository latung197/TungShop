﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TungShop.Model.Abstract;
using System.Xml.Linq;

namespace TungShop.Model.Model
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(500)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public string MetaKeyword { get; set; }
        public bool HomeFlag { get; set; }
        public string Image { get; set; }
        public bool HotFlag { get; set; }
        public int ViewCount { get; set; }
        public XElement MorreImages { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal Promotion { get; set; }
        public int Warranty { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategorie ProductCategorie { get; set; }

       
    }
}
